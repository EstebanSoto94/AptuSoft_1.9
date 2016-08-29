 
// Type: Aptusoft.InternoAptusoft.Ciclos.CicloNegocio
 
 
// version 1.8.0

using System;
using System.Collections.Generic;

namespace Aptusoft.InternoAptusoft.Ciclos
{
  public class CicloNegocio
  {
    private List<CicloVO> _listaCiclo = new List<CicloVO>();

    private List<CicloVO> ListaCiclos()
    {
      this._listaCiclo = new Ciclo().ListaCiclos();
      return this._listaCiclo;
    }

    public List<CicloVO> PrimeraFacturacion(DateTime fechaContratacion)
    {
      this.ListaCiclos();
      int day = fechaContratacion.Day;
      int month1 = fechaContratacion.Month;
      int year = fechaContratacion.Year;
      List<CicloVO> list = new List<CicloVO>();
      DateTime now1 = DateTime.Now;
      DateTime now2 = DateTime.Now;
      foreach (CicloVO cicloVo in this._listaCiclo)
      {
        if (cicloVo.DiaContratacionDesde <= day && cicloVo.DiaContratacionHasta >= day)
        {
          int month2;
          if (fechaContratacion.Month == 12)
          {
            ++year;
            month2 = cicloVo.MesPrimeraFacturacion;
          }
          else
          {
            month2 = month1 + cicloVo.MesPrimeraFacturacion;
            if (month2 > 12)
            {
              month2 -= 12;
              ++year;
            }
          }
          DateTime dateTime1= new DateTime(year, month2, cicloVo.DiaFacturacion, fechaContratacion.Hour, fechaContratacion.Minute, fechaContratacion.Second);
          cicloVo.FechaFacturacion = dateTime1;
          DateTime dateTime2 = new DateTime(year, month2, cicloVo.DiaVencimiento, fechaContratacion.Hour, fechaContratacion.Minute, fechaContratacion.Second);
          cicloVo.FechaVencimiento = dateTime2;
          list.Add(cicloVo);
          break;
        }
      }
      return list;
    }

    public CicloVO BuscaCicloCodigo(int codigo)
    {
      this.ListaCiclos();
      CicloVO cicloVo1 = new CicloVO();
      foreach (CicloVO cicloVo2 in this._listaCiclo)
      {
        if (cicloVo2.CodigoCiclo == codigo)
        {
          cicloVo1 = cicloVo2;
          break;
        }
      }
      return cicloVo1;
    }
  }
}
