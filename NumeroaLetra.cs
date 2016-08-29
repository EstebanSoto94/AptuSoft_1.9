 
// Type: Aptusoft.NumeroaLetra
 
 
// version 1.8.0

using System;

namespace Aptusoft
{
  internal class NumeroaLetra
  {
    public string enletras(string num)
    {
      string str = "";
      double d;
      try
      {
        d = Convert.ToDouble(num);
      }
      catch
      {
        return "";
      }
      long num1 = Convert.ToInt64(Math.Truncate(d));
      int num2 = Convert.ToInt32(Math.Round((d - (double) num1) * 100.0, 2));
      if (num2 > 0)
        str = " CON " + num2.ToString() + "/100";
      return this.toText(Convert.ToDouble(num1)) + str;
    }

    private string toText(double value)
    {
      value = Math.Truncate(value);
      string str;
      if (value == 0.0)
        str = "CERO";
      else if (value == 1.0)
        str = "UNO";
      else if (value == 2.0)
        str = "DOS";
      else if (value == 3.0)
        str = "TRES";
      else if (value == 4.0)
        str = "CUATRO";
      else if (value == 5.0)
        str = "CINCO";
      else if (value == 6.0)
        str = "SEIS";
      else if (value == 7.0)
        str = "SIETE";
      else if (value == 8.0)
        str = "OCHO";
      else if (value == 9.0)
        str = "NUEVE";
      else if (value == 10.0)
        str = "DIEZ";
      else if (value == 11.0)
        str = "ONCE";
      else if (value == 12.0)
        str = "DOCE";
      else if (value == 13.0)
        str = "TRECE";
      else if (value == 14.0)
        str = "CATORCE";
      else if (value == 15.0)
        str = "QUINCE";
      else if (value < 20.0)
        str = "DIECI" + this.toText(value - 10.0);
      else if (value == 20.0)
        str = "VEINTE";
      else if (value < 30.0)
        str = "VEINTI" + this.toText(value - 20.0);
      else if (value == 30.0)
        str = "TREINTA";
      else if (value == 40.0)
        str = "CUARENTA";
      else if (value == 50.0)
        str = "CINCUENTA";
      else if (value == 60.0)
        str = "SESENTA";
      else if (value == 70.0)
        str = "SETENTA";
      else if (value == 80.0)
        str = "OCHENTA";
      else if (value == 90.0)
        str = "NOVENTA";
      else if (value < 100.0)
        str = this.toText(Math.Truncate(value / 10.0) * 10.0) + " Y " + this.toText(value % 10.0);
      else if (value == 100.0)
        str = "CIEN";
      else if (value < 200.0)
        str = "CIENTO " + this.toText(value - 100.0);
      else if (value == 200.0 || value == 300.0 || (value == 400.0 || value == 600.0) || value == 800.0)
        str = this.toText(Math.Truncate(value / 100.0)) + "CIENTOS";
      else if (value == 500.0)
        str = "QUINIENTOS";
      else if (value == 700.0)
        str = "SETECIENTOS";
      else if (value == 900.0)
        str = "NOVECIENTOS";
      else if (value < 1000.0)
        str = this.toText(Math.Truncate(value / 100.0) * 100.0) + " " + this.toText(value % 100.0);
      else if (value == 1000.0)
        str = "MIL";
      else if (value < 2000.0)
        str = "MIL " + this.toText(value % 1000.0);
      else if (value < 1000000.0)
      {
        str = this.toText(Math.Truncate(value / 1000.0)) + " MIL";
        if (value % 1000.0 > 0.0)
          str = str + " " + this.toText(value % 1000.0);
      }
      else if (value == 1000000.0)
        str = "UN MILLON";
      else if (value < 2000000.0)
        str = "UN MILLON " + this.toText(value % 1000000.0);
      else if (value < 1000000000000.0)
      {
        str = this.toText(Math.Truncate(value / 1000000.0)) + " MILLONES ";
        if (value - Math.Truncate(value / 1000000.0) * 1000000.0 > 0.0)
          str = str + " " + this.toText(value - Math.Truncate(value / 1000000.0) * 1000000.0);
      }
      else if (value == 1000000000000.0)
        str = "UN BILLON";
      else if (value < 2000000000000.0)
      {
        str = "UN BILLON " + this.toText(value - Math.Truncate(value / 1000000000000.0) * 1000000000000.0);
      }
      else
      {
        str = this.toText(Math.Truncate(value / 1000000000000.0)) + " BILLONES";
        if (value - Math.Truncate(value / 1000000000000.0) * 1000000000000.0 > 0.0)
          str = str + " " + this.toText(value - Math.Truncate(value / 1000000000000.0) * 1000000000000.0);
      }
      return str;
    }
  }
}
