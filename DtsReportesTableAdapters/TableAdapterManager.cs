 
// Type: Aptusoft.DtsReportesTableAdapters.TableAdapterManager
 
 
// version 1.8.0

using Aptusoft;
using MySql.Data.MySqlClient;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Diagnostics;

namespace Aptusoft.DtsReportesTableAdapters
{
  [DesignerCategory("code")]
  [Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [HelpKeyword("vs.data.TableAdapterManager")]
  [ToolboxItem(true)]
  public class TableAdapterManager : Component
  {
    private TableAdapterManager.UpdateOrderOption _updateOrder;
    private ImagenesTableAdapter _imagenesTableAdapter;
    private bool _backupDataSetBeforeUpdate;
    private IDbConnection _connection;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public TableAdapterManager.UpdateOrderOption UpdateOrder
    {
      get
      {
        return this._updateOrder;
      }
      set
      {
        this._updateOrder = value;
      }
    }

    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public ImagenesTableAdapter ImagenesTableAdapter
    {
      get
      {
        return this._imagenesTableAdapter;
      }
      set
      {
        this._imagenesTableAdapter = value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool BackupDataSetBeforeUpdate
    {
      get
      {
        return this._backupDataSetBeforeUpdate;
      }
      set
      {
        this._backupDataSetBeforeUpdate = value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public IDbConnection Connection
    {
      get
      {
        if (this._connection != null)
          return this._connection;
        if (this._imagenesTableAdapter != null && this._imagenesTableAdapter.Connection != null)
          return (IDbConnection) this._imagenesTableAdapter.Connection;
        return (IDbConnection) null;
      }
      set
      {
        this._connection = value;
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    [DebuggerNonUserCode]
    public int TableAdapterInstanceCount
    {
      get
      {
        int num = 0;
        if (this._imagenesTableAdapter != null)
          ++num;
        return num;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private int UpdateUpdatedRows(DtsReportes dataSet, List<DataRow> allChangedRows, List<DataRow> allAddedRows)
    {
      int num = 0;
      if (this._imagenesTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.Imagenes.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._imagenesTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      return num;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    private int UpdateInsertedRows(DtsReportes dataSet, List<DataRow> allAddedRows)
    {
      int num = 0;
      if (this._imagenesTableAdapter != null)
      {
        DataRow[] dataRows = dataSet.Imagenes.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRows != null && 0 < dataRows.Length)
        {
          num += this._imagenesTableAdapter.Update(dataRows);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRows);
        }
      }
      return num;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    private int UpdateDeletedRows(DtsReportes dataSet, List<DataRow> allChangedRows)
    {
      int num = 0;
      if (this._imagenesTableAdapter != null)
      {
        DataRow[] dataRows = dataSet.Imagenes.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRows != null && 0 < dataRows.Length)
        {
          num += this._imagenesTableAdapter.Update(dataRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRows);
        }
      }
      return num;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private DataRow[] GetRealUpdatedRows(DataRow[] updatedRows, List<DataRow> allAddedRows)
    {
      if (updatedRows == null || updatedRows.Length < 1 || (allAddedRows == null || allAddedRows.Count < 1))
        return updatedRows;
      List<DataRow> list = new List<DataRow>();
      for (int index = 0; index < updatedRows.Length; ++index)
      {
        DataRow dataRow = updatedRows[index];
        if (!allAddedRows.Contains(dataRow))
          list.Add(dataRow);
      }
      return list.ToArray();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public virtual int UpdateAll(DtsReportes dataSet)
    {
      if (dataSet == null)
        throw new ArgumentNullException("dataSet");
      if (!dataSet.HasChanges())
        return 0;
      if (this._imagenesTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._imagenesTableAdapter.Connection))
        throw new ArgumentException("Todos los TableAdapters administrados por un TableAdapterManager deben usar la misma cadena de conexión.");
      IDbConnection connection = this.Connection;
      if (connection == null)
        throw new ApplicationException("TableAdapterManager no contiene información de conexión. Establezca cada propiedad TableAdapterManager TableAdapter en una instancia TableAdapter válida.");
      bool flag = false;
      if ((connection.State & ConnectionState.Broken) == ConnectionState.Broken)
        connection.Close();
      if (connection.State == ConnectionState.Closed)
      {
        connection.Open();
        flag = true;
      }
      IDbTransaction dbTransaction = connection.BeginTransaction();
      if (dbTransaction == null)
        throw new ApplicationException("La transacción no puede comenzar. La conexión de datos actual no es compatible con las transacciones o el estado actual no permite que comience la transacción.");
      List<DataRow> allChangedRows = new List<DataRow>();
      List<DataRow> allAddedRows = new List<DataRow>();
      List<DataAdapter> list = new List<DataAdapter>();
      Dictionary<object, IDbConnection> dictionary = new Dictionary<object, IDbConnection>();
      int num = 0;
      DataSet dataSet1 = (DataSet) null;
      if (this.BackupDataSetBeforeUpdate)
      {
        dataSet1 = new DataSet();
        dataSet1.Merge((DataSet) dataSet);
      }
      try
      {
        if (this._imagenesTableAdapter != null)
        {
          dictionary.Add((object) this._imagenesTableAdapter, (IDbConnection) this._imagenesTableAdapter.Connection);
          this._imagenesTableAdapter.Connection = (MySqlConnection) connection;
          this._imagenesTableAdapter.Transaction = (MySqlTransaction) dbTransaction;
          if (((DataAdapter) this._imagenesTableAdapter.Adapter).AcceptChangesDuringUpdate)
          {
            ((DataAdapter) this._imagenesTableAdapter.Adapter).AcceptChangesDuringUpdate = false;
            list.Add((DataAdapter) this._imagenesTableAdapter.Adapter);
          }
        }
        if (this.UpdateOrder == TableAdapterManager.UpdateOrderOption.UpdateInsertDelete)
        {
          num += this.UpdateUpdatedRows(dataSet, allChangedRows, allAddedRows);
          num += this.UpdateInsertedRows(dataSet, allAddedRows);
        }
        else
        {
          num += this.UpdateInsertedRows(dataSet, allAddedRows);
          num += this.UpdateUpdatedRows(dataSet, allChangedRows, allAddedRows);
        }
        num += this.UpdateDeletedRows(dataSet, allChangedRows);
        dbTransaction.Commit();
        if (0 < allAddedRows.Count)
        {
          DataRow[] array = new DataRow[allAddedRows.Count];
          allAddedRows.CopyTo(array);
          for (int index = 0; index < array.Length; ++index)
            array[index].AcceptChanges();
        }
        if (0 < allChangedRows.Count)
        {
          DataRow[] array = new DataRow[allChangedRows.Count];
          allChangedRows.CopyTo(array);
          for (int index = 0; index < array.Length; ++index)
            array[index].AcceptChanges();
        }
      }
      catch (Exception ex)
      {
        dbTransaction.Rollback();
        if (this.BackupDataSetBeforeUpdate)
        {
          Debug.Assert(dataSet1 != null);
          dataSet.Clear();
          dataSet.Merge(dataSet1);
        }
        else if (0 < allAddedRows.Count)
        {
          DataRow[] array = new DataRow[allAddedRows.Count];
          allAddedRows.CopyTo(array);
          for (int index = 0; index < array.Length; ++index)
          {
            DataRow dataRow = array[index];
            dataRow.AcceptChanges();
            dataRow.SetAdded();
          }
        }
        throw ex;
      }
      finally
      {
        if (flag)
          connection.Close();
        if (this._imagenesTableAdapter != null)
        {
          this._imagenesTableAdapter.Connection = (MySqlConnection) dictionary[(object) this._imagenesTableAdapter];
          this._imagenesTableAdapter.Transaction = (MySqlTransaction) null;
        }
        if (0 < list.Count)
        {
          DataAdapter[] array = new DataAdapter[list.Count];
          list.CopyTo(array);
          for (int index = 0; index < array.Length; ++index)
            array[index].AcceptChangesDuringUpdate = true;
        }
      }
      return num;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected virtual void SortSelfReferenceRows(DataRow[] rows, DataRelation relation, bool childFirst)
    {
      Array.Sort<DataRow>(rows, (IComparer<DataRow>) new TableAdapterManager.SelfReferenceComparer(relation, childFirst));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected virtual bool MatchTableAdapterConnection(IDbConnection inputConnection)
    {
      return this._connection != null || (this.Connection == null || inputConnection == null || string.Equals(this.Connection.ConnectionString, inputConnection.ConnectionString, StringComparison.Ordinal));
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public enum UpdateOrderOption
    {
      InsertUpdateDelete,
      UpdateInsertDelete,
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private class SelfReferenceComparer : IComparer<DataRow>
    {
      private DataRelation _relation;
      private int _childFirst;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      internal SelfReferenceComparer(DataRelation relation, bool childFirst)
      {
        this._relation = relation;
        if (childFirst)
          this._childFirst = -1;
        else
          this._childFirst = 1;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      private DataRow GetRoot(DataRow row, out int distance)
      {
        Debug.Assert(row != null);
        DataRow dataRow = row;
        distance = 0;
        IDictionary<DataRow, DataRow> dictionary = (IDictionary<DataRow, DataRow>) new Dictionary<DataRow, DataRow>();
        dictionary[row] = row;
        for (DataRow parentRow = row.GetParentRow(this._relation, DataRowVersion.Default); parentRow != null && !dictionary.ContainsKey(parentRow); parentRow = parentRow.GetParentRow(this._relation, DataRowVersion.Default))
        {
          distance = distance + 1;
          dataRow = parentRow;
          dictionary[parentRow] = parentRow;
        }
        if (distance == 0)
        {
          dictionary.Clear();
          dictionary[row] = row;
          for (DataRow parentRow = row.GetParentRow(this._relation, DataRowVersion.Original); parentRow != null && !dictionary.ContainsKey(parentRow); parentRow = parentRow.GetParentRow(this._relation, DataRowVersion.Original))
          {
            distance = distance + 1;
            dataRow = parentRow;
            dictionary[parentRow] = parentRow;
          }
        }
        return dataRow;
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public int Compare(DataRow row1, DataRow row2)
      {
        if (object.ReferenceEquals((object) row1, (object) row2))
          return 0;
        if (row1 == null)
          return -1;
        if (row2 == null)
          return 1;
        int distance1 = 0;
        DataRow root1 = this.GetRoot(row1, out distance1);
        int distance2 = 0;
        DataRow root2 = this.GetRoot(row2, out distance2);
        if (object.ReferenceEquals((object) root1, (object) root2))
          return this._childFirst * distance1.CompareTo(distance2);
        Debug.Assert(root1.Table != null && root2.Table != null);
        return root1.Table.Rows.IndexOf(root1) < root2.Table.Rows.IndexOf(root2) ? -1 : 1;
      }
    }
  }
}
