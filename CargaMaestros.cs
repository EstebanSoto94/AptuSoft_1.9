 
// Type: Aptusoft.CargaMaestros
 
 
// version 1.8.0

using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace Aptusoft
{
  internal class CargaMaestros
  {
    public DataTable cargaBodega()
    {
      return new BodegaCajaListaOtros().listaBodegas();
    }

    #region CÓDIGO COMENTADO cargaTipoDocumento Antiguo
    //public DataTable cargaTipoDocumentos1()
    //{
    //  DataTable dataTable = new DataTable();
    //  dataTable.Columns.Add("codigo");
    //  dataTable.Columns.Add("descripcion");
    //  DataRow row1 = dataTable.NewRow();
    //  row1["codigo"] = (object) 0;
    //  row1["descripcion"] = (object) "[SELECCIONE]";
    //  dataTable.Rows.Add(row1);
    //  DataRow row2 = dataTable.NewRow();
    //  row2["codigo"] = (object) 1;
    //  row2["descripcion"] = (object) "FACTURA COMPRA";
    //  dataTable.Rows.Add(row2);
    //  DataRow row3 = dataTable.NewRow();
    //  row3["codigo"] = (object) 2;
    //  row3["descripcion"] = (object) "GUIA DESPACHO";
    //  dataTable.Rows.Add(row3);
    //  DataRow row4 = dataTable.NewRow();
    //  row4["codigo"] = (object) 3;
    //  row4["descripcion"] = (object) "OTRO DOCUMENTO";
    //  dataTable.Rows.Add(row4);
    //  DataRow row5 = dataTable.NewRow();
    //  row5["codigo"] = (object) 4;
    //  row5["descripcion"] = (object) "NOTA DE CREDITO";
    //  dataTable.Rows.Add(row5);
    //  DataRow row6 = dataTable.NewRow();
    //  row6["codigo"] = (object) 5;
    //  row6["descripcion"] = (object) "FACTURA ELECTRONICA";
    //  dataTable.Rows.Add(row6);
    //  DataRow row7 = dataTable.NewRow();
    //  row7["codigo"] = (object) 6;
    //  row7["descripcion"] = (object) "NOTA CREDITO ELECTRONICA";
    //  dataTable.Rows.Add(row7);
    //  DataRow row8 = dataTable.NewRow();
    //  row8["codigo"] = (object) 7;
    //  row8["descripcion"] = (object) "NOTA DEBITO ELECTRONICA";
    //  dataTable.Rows.Add(row8);
    //  return dataTable;
    //}
    #endregion

    //cargaTipoDocumentos Nuevo incluida FACTURA ELECTRONICA
    public DataTable cargaTipoDocumentos()
    {
        DataTable dataTable = new DataTable();
        dataTable.Columns.Add("codigo");
        dataTable.Columns.Add("descripcion");

        DataRow row1 = dataTable.NewRow();
        row1["codigo"] = (object)0;
        row1["descripcion"] = (object)"[SELECCIONE]";
        dataTable.Rows.Add(row1);
        
        DataRow row2 = dataTable.NewRow();
        row2["codigo"] = (object)1;
        row2["descripcion"] = (object)"FACTURA";
        dataTable.Rows.Add(row2);
        
        DataRow row3 = dataTable.NewRow();
        row3["codigo"] = (object)2;
        row3["descripcion"] = (object)"FACTURA ELECTRONICA";
        dataTable.Rows.Add(row3);
        
        DataRow row4 = dataTable.NewRow();
        row4["codigo"] = (object)3;
        row4["descripcion"] = (object)"FACTURA COMPRA";
        dataTable.Rows.Add(row4);
        
        DataRow row5 = dataTable.NewRow();
        row5["codigo"] = (object)4;
        row5["descripcion"] = (object)"FACTURA COMPRA ELECTRONICA";
        dataTable.Rows.Add(row5);

        DataRow row6 = dataTable.NewRow();
        row6["codigo"] = (object)5;
        row6["descripcion"] = (object)"FACTURA NO AFECTA O EXENTA";
        dataTable.Rows.Add(row6);

        //flag
        DataRow row7 = dataTable.NewRow();
        row7["codigo"] = (object)6;
        row7["descripcion"] = (object)"FACTURA EXENTA ELECTRONICA";
        dataTable.Rows.Add(row7);
        
        DataRow row8 = dataTable.NewRow();
        row8["codigo"] = (object)7;
        row8["descripcion"] = (object)"NOTA CREDITO";
        dataTable.Rows.Add(row8);
        
        DataRow row9 = dataTable.NewRow();
        row9["codigo"] = (object)8;
        row9["descripcion"] = (object)"NOTA CREDITO ELECTRONICA";
        dataTable.Rows.Add(row9);

        DataRow row10 = dataTable.NewRow();
        row10["codigo"] = (object)9;
        row10["descripcion"] = (object)"NOTA DEBITO";
        dataTable.Rows.Add(row10);

        DataRow row11 = dataTable.NewRow();
        row11["codigo"] = (object)10;
        row11["descripcion"] = (object)"NOTA DEBITO ELECTRONICA";
        dataTable.Rows.Add(row11);

        DataRow row12 = dataTable.NewRow();
        row12["codigo"] = (object)11;
        row12["descripcion"] = (object)"OTRO DOCUMENTO";
        dataTable.Rows.Add(row12);
        
        return dataTable;
    }

    public DataTable cargaEstadosPago()
    {
      DataTable dataTable = new DataTable();
      dataTable.Columns.Add("codigo");
      dataTable.Columns.Add("descripcion");
      DataRow row1 = dataTable.NewRow();
      row1["codigo"] = (object) 0;
      row1["descripcion"] = (object) "[TODOS]";
      dataTable.Rows.Add(row1);
      DataRow row2 = dataTable.NewRow();
      row2["codigo"] = (object) 1;
      row2["descripcion"] = (object) "PAGADO";
      dataTable.Rows.Add(row2);
      DataRow row3 = dataTable.NewRow();
      row3["codigo"] = (object) 2;
      row3["descripcion"] = (object) "DOCUMENTADO";
      dataTable.Rows.Add(row3);
      DataRow row4 = dataTable.NewRow();
      row4["codigo"] = (object) 3;
      row4["descripcion"] = (object) "PENDIENTE";
      dataTable.Rows.Add(row4);
      return dataTable;
    }

    #region CÓDIGO COMENTADO cargaTipoDocumentosBusqueda Antigua
    //public DataTable cargaTipoDocumentosBusqueda()
    //{
    //  DataTable dataTable = new DataTable();
    //  dataTable.Columns.Add("codigo");
    //  dataTable.Columns.Add("descripcion");
    //  DataRow row1 = dataTable.NewRow();
    //  row1["codigo"] = (object) 0;
    //  row1["descripcion"] = (object) "[TODOS]";
    //  dataTable.Rows.Add(row1);
    //  DataRow row2 = dataTable.NewRow();
    //  row2["codigo"] = (object) 1;
    //  row2["descripcion"] = (object) "FACTURA COMPRA";
    //  dataTable.Rows.Add(row2);
    //  DataRow row3 = dataTable.NewRow();
    //  row3["codigo"] = (object) 2;
    //  row3["descripcion"] = (object) "GUIA DESPACHO";
    //  dataTable.Rows.Add(row3);
    //  DataRow row4 = dataTable.NewRow();
    //  row4["codigo"] = (object) 3;
    //  row4["descripcion"] = (object) "OTRO DOCUMENTO";
    //  dataTable.Rows.Add(row4);
    //  DataRow row5 = dataTable.NewRow();
    //  row5["codigo"] = (object) 4;
    //  row5["descripcion"] = (object) "NOTA DE CREDITO";
    //  dataTable.Rows.Add(row5);
    //  DataRow row6 = dataTable.NewRow();
    //  row6["codigo"] = (object) 5;
    //  row6["descripcion"] = (object) "FACTURA ELECTRONICA";
    //  dataTable.Rows.Add(row6);
    //  DataRow row7 = dataTable.NewRow();
    //  row7["codigo"] = (object) 6;
    //  row7["descripcion"] = (object) "NOTA CREDITO ELECTRONICA";
    //  dataTable.Rows.Add(row7);
    //  DataRow row8 = dataTable.NewRow();
    //  row8["codigo"] = (object) 7;
    //  row8["descripcion"] = (object) "NOTA DEBITO ELECTRONICA";
    //  dataTable.Rows.Add(row8);
    //  return dataTable;
    //}
    #endregion

    // Nueva busqueda utilizando el metodo de cargaTipoDocumentos
    public DataTable cargaTipoDocumentosBusquedaFacturasCompra()
    {
        DataTable dataTable = new DataTable();
        dataTable.Columns.Add("codigo");
        dataTable.Columns.Add("descripcion");
        DataRow row1 = dataTable.NewRow();
        row1["codigo"] = (object)0;
        row1["descripcion"] = (object)"[TODOS]";
        dataTable.Rows.Add(row1);
        DataRow row2 = dataTable.NewRow();
        row2["codigo"] = (object)1;
        row2["descripcion"] = (object)"FACTURA COMPRA";
        dataTable.Rows.Add(row2);
        
        DataRow row4 = dataTable.NewRow();
        row4["codigo"] = (object)3;
        row4["descripcion"] = (object)"FACTURA";
        dataTable.Rows.Add(row4);
        DataRow row5 = dataTable.NewRow();
        row5["codigo"] = (object)4;
        row5["descripcion"] = (object)"NOTA DE CREDITO";
        dataTable.Rows.Add(row5);
        DataRow row6 = dataTable.NewRow();
        row6["codigo"] = (object)5;
        row6["descripcion"] = (object)"FACTURA ELECTRONICA";
        dataTable.Rows.Add(row6);
        DataRow row7 = dataTable.NewRow();
        row7["codigo"] = (object)6;
        row7["descripcion"] = (object)"NOTA CREDITO ELECTRONICA";
        dataTable.Rows.Add(row7);
        DataRow row8 = dataTable.NewRow();
        row8["codigo"] = (object)7;
        row8["descripcion"] = (object)"NOTA DEBITO ELECTRONICA";
        dataTable.Rows.Add(row8);
        
        DataRow row10 = dataTable.NewRow();
        row10["codigo"] = (object)9;
        row10["descripcion"] = (object)"FACTURA COMPRA ELECTRONICA";
        dataTable.Rows.Add(row10);
        DataRow row11 = dataTable.NewRow();
        row10["codigo"] = (object)10;
        row10["descripcion"] = (object)"OTRO DOCUMENTO";
        dataTable.Rows.Add(row11);
        return dataTable;
    }

    #region CÓDIGO COMENTADO Busqueda antigua
    //public DataTable cargaTipoDocumentosBusquedaFacturasCompra1()
    //{
    //    DataTable dataTable = new DataTable();
    //    dataTable.Columns.Add("codigo");
    //    dataTable.Columns.Add("descripcion");
    //    DataRow row1 = dataTable.NewRow();
    //    row1["codigo"] = (object)0;
    //    row1["descripcion"] = (object)"[TODOS]";
    //    dataTable.Rows.Add(row1);
    //    DataRow row2 = dataTable.NewRow();
    //    row2["codigo"] = (object)1;
    //    row2["descripcion"] = (object)"FACTURA COMPRA";
    //    dataTable.Rows.Add(row2);
    //    DataRow row3 = dataTable.NewRow();
    //    row3["codigo"] = (object)5;
    //    row3["descripcion"] = (object)"FACTURA ELECTRONICA";
    //    dataTable.Rows.Add(row3);
    //    return dataTable;
    //}
    #endregion

    public DataTable cargaListaPrecio()
    {
      return new BodegaCajaListaOtros().listaListas_Precio();
    }

    public DataTable listaVendedores()
    {
      Conexion conecta = Conexion.getConecta();
      DataTable dataTable = new DataTable();
      ((DbDataAdapter) new MySqlDataAdapter("SELECT idVendedor, nombre FROM vendedores ORDER BY idVendedor", conecta.ConexionMySql)).Fill(dataTable);
      DataRow row = dataTable.NewRow();
      row[0] = (object) 0;
      row[1] = (object) "[SELECCIONE]";
      dataTable.Rows.Add(row);
      dataTable.DefaultView.Sort = "idVendedor ASC";
      return dataTable;
    }

    public List<BodegaVO> listaEstadoOT()
    {
      List<BodegaVO> list = new List<BodegaVO>();
      BodegaVO bodegaVo = new BodegaVO();
      list.Add(new BodegaVO()
      {
        IdBodega = 1,
        nombreBodega = "PENDIENTE"
      });
      list.Add(new BodegaVO()
      {
        IdBodega = 2,
        nombreBodega = "FINALIZADA"
      });
      list.Add(new BodegaVO()
      {
        IdBodega = 3,
        nombreBodega = "ATENDIENDO"
      });
      return list;
    }

    public List<BodegaVO> listaEstadoOrdenTrabajo()
    {
      List<BodegaVO> list = new List<BodegaVO>();
      BodegaVO bodegaVo = new BodegaVO();
      list.Add(new BodegaVO()
      {
        IdBodega = 0,
        nombreBodega = "PENDIENTE"
      });
      list.Add(new BodegaVO()
      {
        IdBodega = 1,
        nombreBodega = "FINALIZADA"
      });
      return list;
    }

    public List<BodegaVO> listaEstadoOrdenTrabajoInforme()
    {
      List<BodegaVO> list = new List<BodegaVO>();
      BodegaVO bodegaVo = new BodegaVO();
      list.Add(new BodegaVO()
      {
        IdBodega = 0,
        nombreBodega = "PENDIENTE"
      });
      list.Add(new BodegaVO()
      {
        IdBodega = 1,
        nombreBodega = "FINALIZADA"
      });
      list.Add(new BodegaVO()
      {
        IdBodega = 3,
        nombreBodega = "TODAS"
      });
      return list;
    }

    public DataTable cargaTipoDocumentoVenta()
    {
      DataTable dataTable = new DataTable();
      dataTable.Columns.Add("codigo");
      dataTable.Columns.Add("descripcion");
      DataRow row1 = dataTable.NewRow();
      row1[0] = (object) 0;
      row1[1] = (object) "[SELECCIONE]";
      dataTable.Rows.Add(row1);
      DataRow row2 = dataTable.NewRow();
      row2["codigo"] = (object) 5;
      row2["descripcion"] = (object) "FACTURA_ELECTRONICA";
      dataTable.Rows.Add(row2);
      DataRow row3 = dataTable.NewRow();
      row3["codigo"] = (object) 3;
      row3["descripcion"] = (object) "BOLETA";
      dataTable.Rows.Add(row3);
      DataRow row4 = dataTable.NewRow();
      row4["codigo"] = (object) 1;
      row4["descripcion"] = (object) "FACTURA";
      dataTable.Rows.Add(row4);
      DataRow row5 = dataTable.NewRow();
      row5["codigo"] = (object) 2;
      row5["descripcion"] = (object) "FACTURA EXENTA";
      dataTable.Rows.Add(row5);
      if (frmMenuPrincipal._Fiscal)
      {
        DataRow row6 = dataTable.NewRow();
        row6["codigo"] = (object) 4;
        row6["descripcion"] = (object) "BOLETA FISCAL";
        dataTable.Rows.Add(row6);
      }
      DataRow row7 = dataTable.NewRow();
      row7["codigo"] = (object) 6;
      row7["descripcion"] = (object) "FACTURA_EXENTA_ELECTRONICA";
      dataTable.Rows.Add(row7);
      DataRow row8 = dataTable.NewRow();
      row8["codigo"] = (object) 7;
      row8["descripcion"] = (object) "VOUCHER";
      dataTable.Rows.Add(row8);
      return dataTable;
    }

    public DataTable listaBancos()
    {
      Conexion conecta = Conexion.getConecta();
      DataTable dataTable = new DataTable();
      ((DbDataAdapter) new MySqlDataAdapter("SELECT idBanco, nombreBanco FROM banco ORDER BY idBanco", conecta.ConexionMySql)).Fill(dataTable);
      DataRow row = dataTable.NewRow();
      row[0] = (object) 0;
      row[1] = (object) "[SELECCIONE]";
      dataTable.Rows.Add(row);
      dataTable.DefaultView.Sort = "idBanco ASC";
      return dataTable;
    }

    public List<BodegaVO> cargaBodegaUsuario()
    {
      List<BodegaVO> list = new BodegaCajaListaOtros().listaBodegasList();
      list.Add(new BodegaVO()
      {
        IdBodega = 0,
        nombreBodega = "TODAS"
      });
      return list;
    }

    public List<BodegaVO> cargaTipoBusquedaClientePro()
    {
      return new List<BodegaVO>()
      {
        new BodegaVO()
        {
          IdBodega = 1,
          nombreBodega = "Nombre o Razon Social"
        },
        new BodegaVO()
        {
          IdBodega = 2,
          nombreBodega = "Nombre de Fantasia"
        },
        new BodegaVO()
        {
          IdBodega = 3,
          nombreBodega = "Dirección"
        },
        new BodegaVO()
        {
          IdBodega = 4,
          nombreBodega = "Ciudad"
        },
        new BodegaVO()
        {
          IdBodega = 5,
          nombreBodega = "Comuna"
        },
        new BodegaVO()
        {
          IdBodega = 6,
          nombreBodega = "Telefono"
        },
        new BodegaVO()
        {
          IdBodega = 7,
          nombreBodega = "Contacto"
        },
        new BodegaVO()
        {
          IdBodega = 8,
          nombreBodega = "Giro"
        }
      };
    }

    public List<ListaPrecioVO> cargaListaPrecioUsuario()
    {
      List<ListaPrecioVO> list = new BodegaCajaListaOtros().listaListaPrecioList();
      list.Add(new ListaPrecioVO()
      {
        IdListaPrecio = 0,
        nombreListaPrecio = "TODAS"
      });
      return list;
    }

    public List<CajaVO> cargaCajaUsuario()
    {
      return new BodegaCajaListaOtros().listaCajaList();
    }

    public DataTable cargaValoresOdepa()
    {
        Conexion conecta = Conexion.getConecta();
        DataTable dataTable = new DataTable();

        MySqlCommand consulta = new MySqlCommand("SELECT nombre_cat, valor FROM odepa", conecta.ConexionMySql);

        MySqlDataReader Reader;
        Reader = consulta.ExecuteReader();
        dataTable.Load(Reader);
        Reader.Close();

        return dataTable;
    }

    public string traeValorCategria(string cat)
    {
        Conexion conecta = Conexion.getConecta();
        DataTable dataTable = new DataTable();

        MySqlCommand consulta = new MySqlCommand("SELECT valor FROM odepa WHERE nombre_cat = '" + cat + "'", conecta.ConexionMySql);
        string valor = "";
        MySqlDataReader Reader;
        Reader = consulta.ExecuteReader();

        while (Reader.Read())
        {
            valor = Reader["valor"].ToString();
        }

        Reader.Close();

        return valor;
    }
  }
}
