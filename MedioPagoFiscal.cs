 
// Type: Aptusoft.MedioPagoFiscal
 
 
// version 1.8.0

using System;
using System.Collections.Generic;
using System.Data;

namespace Aptusoft
{
  public class MedioPagoFiscal
  {
    public void agregaMedioPago(MedioPagoVO mpVO)
    {
    }

    public void actualizaMEDIO(MedioPagoVO mpVO)
    {
    }

    public void eliminaMEDIO(int idMedio)
    {
    }

    public DataTable listaMediosPago()
    {
      return new DataTable();
    }

    public List<MedioPagoVO> listaMediosPagoVenta()
    {
      return new List<MedioPagoVO>();
    }

    public List<MedioPagoVO> listaMediosPagoVentaFiscal()
    {
      List<MedioPagoVO> list = new List<MedioPagoVO>();
      DataSet dataSet = new DataSet("datos");
      int num = (int) dataSet.ReadXml("C:\\AptuSoft\\xml\\fiscal.xml");
      DataTable dataTable = dataSet.Tables["pagos"];
      list.Add(new MedioPagoVO()
      {
        IdMedioPago = 0,
        NombreMedioPago = "[SELECCIONE]"
      });
      for (int index = 0; index < dataTable.Rows.Count; ++index)
        list.Add(new MedioPagoVO()
        {
          IdMedioPago = Convert.ToInt32(dataTable.Rows[index]["idMedioPago"].ToString()),
          NombreMedioPago = dataTable.Rows[index]["nombreMedioPago"].ToString(),
          Liquida = Convert.ToBoolean(dataTable.Rows[index]["liquida"]),
          CodigoFiscal = Convert.ToInt32(dataTable.Rows[index]["codigoFiscal"].ToString())
        });
      return list;
    }

    public DataTable listaMediosPagoGrilla()
    {
      DataSet dataSet = new DataSet("datos");
      int num = (int) dataSet.ReadXml("C:\\AptuSoft\\xml\\fiscal.xml");
      return dataSet.Tables["pagos"];
    }

    public bool buscaMedioNombre(string _medio)
    {
      bool flag = false;
      DataSet dataSet = new DataSet();
      int num = (int) dataSet.ReadXml("C:\\AptuSoft\\xml\\fiscal.xml");
      string filterExpression = "nombreMedioPago='" + _medio + "'";
      if (dataSet.Tables["pagos"].Select(filterExpression).Length > 0)
        flag = true;
      return flag;
    }

    public bool buscaCodigoFiscal(string codigo)
    {
      bool flag = false;
      DataSet dataSet = new DataSet();
      int num = (int) dataSet.ReadXml("C:\\AptuSoft\\xml\\fiscal.xml");
      string filterExpression = "codigoFiscal ='" + codigo + "'";
      if (dataSet.Tables["pagos"].Select(filterExpression).Length > 0)
        flag = true;
      return flag;
    }

    public List<int> obtenerCodigoFiscal()
    {
      List<int> list = new List<int>();
      DataSet dataSet = new DataSet("datos");
      int num1 = (int) dataSet.ReadXml("C:\\AptuSoft\\xml\\fiscal.xml");
      DataTable dataTable = dataSet.Tables["pagos"];
      int num2 = Convert.ToInt32(dataTable.Compute("max(codigoFiscal)", string.Empty));
      list.Add(num2 + 1);
      int num3 = Convert.ToInt32(dataTable.Compute("max(idMedioPago)", string.Empty));
      list.Add(num3 + 1);
      return list;
    }

    public int obtieneEstadoLiquida(int idMedio)
    {
      return 0;
    }
  }
}
