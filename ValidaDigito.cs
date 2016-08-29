 
// Type: Aptusoft.ValidaDigito
 
 
// version 1.8.0

namespace Aptusoft
{
  public class ValidaDigito
  {
    public string digitoVerificador(int rut)
    {
      int num1 = 2;
      int num2 = 0;
      while (rut != 0)
      {
        int num3 = rut % 10 * num1;
        num2 += num3;
        rut /= 10;
        ++num1;
        if (num1 == 8)
          num1 = 2;
      }
      int num4 = 11 - num2 % 11;
      string str = num4.ToString().Trim();
      if (num4 == 10)
        str = "K";
      if (num4 == 11)
        str = "0";
      return str;
    }
  }
}
