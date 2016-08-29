 
// Type: Aptusoft.Calculos
 
 
// version 1.8.0

using System;
using System.Collections;
using System.Collections.Generic;

namespace Aptusoft
{
  internal class Calculos
  {
    public Decimal _iva = new Decimal(0);
    public bool _valoresConIva = false;
    public bool _verificaCredito = false;
    public bool _impedirVentasSinCredito = false;
    public bool _verificaFactura = false;
    public bool _verificaFacturaExenta = false;
    public bool _verificaBoleta = false;
    public bool _verificaGuiaSinFacturar = false;
    public bool _verificaFrigorifico = true;
    public Decimal _imp1 = new Decimal(0);
    public Decimal _imp2 = new Decimal(0);
    public Decimal _imp3 = new Decimal(0);
    public Decimal _imp4 = new Decimal(0);
    public Decimal _imp5 = new Decimal(0);

    public Calculos()
    {
      this.rescataOpcionesGenerales();
      this.rescataImpuestosEspeciales();
    }

    public void rescataOpcionesGenerales()
    {
      
      this._iva = frmMenuPrincipal._CalculoDatos.Iva;
      this._valoresConIva = frmMenuPrincipal._CalculoDatos.ValoresConIva;
      this._verificaCredito = frmMenuPrincipal._CalculoDatos.VerificaCredito;
      this._impedirVentasSinCredito = frmMenuPrincipal._CalculoDatos.ImpedirVentasSinCredito;
      this._verificaFactura = frmMenuPrincipal._CalculoDatos.VerificaFactura;
      this._verificaFacturaExenta = frmMenuPrincipal._CalculoDatos.VerificaFacturaExenta;
      this._verificaBoleta = frmMenuPrincipal._CalculoDatos.VerificaBoleta;
      this._verificaGuiaSinFacturar = frmMenuPrincipal._CalculoDatos.VerificaGuiaSinFacturar;
    }

    public void rescataImpuestosEspeciales()
    {
      this._imp1 = frmMenuPrincipal._CalculoDatos.Impuesto1;
      this._imp2 = frmMenuPrincipal._CalculoDatos.Impuesto2;
      this._imp3 = frmMenuPrincipal._CalculoDatos.Impuesto3;
      this._imp4 = frmMenuPrincipal._CalculoDatos.Impuesto4;
      this._imp5 = frmMenuPrincipal._CalculoDatos.Impuesto5;
    }

    public Decimal subTotalLinea(Decimal valor, Decimal cant)
    {
      return valor * cant;
    }

    public Decimal descuentoPorcentajeLinea(Decimal descuento, Decimal subTotal)
    {
      Decimal num;
      try
      {
        num = descuento * new Decimal(100) / subTotal;
      }
      catch (DivideByZeroException ex)
      {
        return new Decimal(0);
      }
      return num;
    }

    public Decimal descuentoValorLinea(Decimal porDesc, Decimal subTotal)
    {
      return subTotal * porDesc / new Decimal(100);
    }

    public Decimal totalLinea(Decimal subTotal, Decimal descuento)
    {
      return subTotal - descuento;
    }

    public Decimal netoLinea(Decimal total, int i1)
    {
      Decimal num = new Decimal(0);
      if (this._valoresConIva)
      {
        if (i1 == 0){
            Decimal a1= this._iva / new Decimal(100)  ;
          num = total / ++a1;
          }
        if (i1 == 1)
        {
            Decimal a2 = (this._iva + this._imp1) / new Decimal(100);
            num = total / ++a2;
        }
        if (i1 == 2)
        {
            Decimal a3 = (this._iva + this._imp2) / new Decimal(100);
            num = total / ++a3;
        }
        if (i1 == 3){
            Decimal a4= (this._iva + this._imp3) / new Decimal(100);
          num = total / ++a4;}
        if (i1 == 4){
            Decimal a5= (this._iva + this._imp4) / new Decimal(100);
          num = total / ++a5 ;}
        if (i1 == 5)
        {
            Decimal a6 = (this._iva + this._imp5) / new Decimal(100);
            num = total / ++a6;
        }
        
        }
      else
        num = total;
      return num;
    }

    public Decimal totalGeneral(List<DatosVentaVO> lista)
    {
      Decimal num = new Decimal(0);
      foreach (DatosVentaVO datosVentaVo in lista)
        num += datosVentaVo.TotalLinea;
      if (!this._valoresConIva){
          Decimal b1 = this._iva / new Decimal(100);
        num *= ++b1;}
      return num;
    }

    public Decimal totalGeneral2(List<DatosVentaVO> lista)
    {
      Decimal num1 = new Decimal(0);
      bool flag = false;
      Decimal num2 = new Decimal(0);
      Decimal num3 = new Decimal(0);
      Decimal num4 = new Decimal(0);
      Decimal num5 = new Decimal(0);
      Decimal num6 = new Decimal(0);
      foreach (DatosVentaVO datosVentaVo in lista)
      {
        num1 += datosVentaVo.TotalLinea;
        if (datosVentaVo.IdImpuesto == 1)
        {
          flag = true;
          num2 = Convert.ToDecimal(this.totalImpuestos(lista)[0].ToString());
        }
        if (datosVentaVo.IdImpuesto == 2)
        {
          flag = true;
          num3 = Convert.ToDecimal(this.totalImpuestos(lista)[1].ToString());
        }
        if (datosVentaVo.IdImpuesto == 3)
        {
          flag = true;
          num4 = Convert.ToDecimal(this.totalImpuestos(lista)[2].ToString());
        }
        if (datosVentaVo.IdImpuesto == 4)
        {
          flag = true;
          num5 = Convert.ToDecimal(this.totalImpuestos(lista)[3].ToString());
        }
        if (datosVentaVo.IdImpuesto == 5)
        {
          flag = true;
          num6 = Convert.ToDecimal(this.totalImpuestos(lista)[4].ToString());
        }
      }
      if (!this._valoresConIva)
      {
          Decimal b2 = this._iva / new Decimal(100);
        num1 *= ++b2;
        if (flag)
          num1 = num1 + num2 + num3 + num4 + num5 + num6;
      }
      return num1;
    }

    public Decimal totalGeneralFacturaElectronica(List<DatosVentaVO> lista)
    {
      Decimal num1 = new Decimal(0);
      bool flag = false;
      Decimal num2 = new Decimal(0);
      Decimal num3 = new Decimal(0);
      Decimal num4 = new Decimal(0);
      Decimal num5 = new Decimal(0);
      Decimal num6 = new Decimal(0);
      foreach (DatosVentaVO datosVentaVo in lista)
      {
        if (!datosVentaVo.Exento)
        {
          num1 += datosVentaVo.TotalLinea;
          if (datosVentaVo.IdImpuesto == 1)
          {
            flag = true;
            num2 = Convert.ToDecimal(this.totalImpuestos(lista)[0].ToString());
          }
          if (datosVentaVo.IdImpuesto == 2)
          {
            flag = true;
            num3 = Convert.ToDecimal(this.totalImpuestos(lista)[1].ToString());
          }
          if (datosVentaVo.IdImpuesto == 3)
          {
            flag = true;
            num4 = Convert.ToDecimal(this.totalImpuestos(lista)[2].ToString());
          }
          if (datosVentaVo.IdImpuesto == 4)
          {
            flag = true;
            num5 = Convert.ToDecimal(this.totalImpuestos(lista)[3].ToString());
          }
          if (datosVentaVo.IdImpuesto == 5)
          {
            flag = true;
            num6 = Convert.ToDecimal(this.totalImpuestos(lista)[4].ToString());
          }
        }
      }
      if (!this._valoresConIva)
      {
          Decimal b3 = this._iva / new Decimal(100);
        num1 *= ++b3;
        if (flag)
          num1 = num1 + num2 + num3 + num4 + num5 + num6;
      }
      return num1;
    }

    public Decimal totalGeneralFacturaExenta(List<DatosVentaVO> lista)
    {
      Decimal num = new Decimal(0);
      foreach (DatosVentaVO datosVentaVo in lista)
        num += datosVentaVo.TotalLinea;
      return num;
    }

    public Decimal totalDescuentoGeneralFacturaExenta(Decimal descuento, Decimal subtotal)
    {
      return !(descuento < subtotal) ? new Decimal(0) : subtotal - descuento;
    }

    public Decimal totalDescuento(List<DatosVentaVO> lista)
    {
      Decimal num = new Decimal(0);
      foreach (DatosVentaVO datosVentaVo in lista)
        num += datosVentaVo.Descuento;
      return num;
    }

    public Decimal totalDescuentoFacturaElectronica(List<DatosVentaVO> lista)
    {
      Decimal num = new Decimal(0);
      foreach (DatosVentaVO datosVentaVo in lista)
      {
        if (!datosVentaVo.Exento)
          num += datosVentaVo.Descuento;
      }
      return num;
    }

    public ArrayList totalDescuentoGeneral(Decimal descuento, Decimal subtotal)
    {
      ArrayList arrayList = new ArrayList();
      if (descuento < subtotal)
      {
        Decimal num1;
        Decimal num2;
        Decimal num3;
        if (!this._valoresConIva)
        {
          num1 = subtotal - descuento;
          num2 = num1 * this._iva / new Decimal(100);
          num3 = num1 + num2;
        }
        else
        {
            Decimal b4 = this._iva / new Decimal(100);
          num1 = (subtotal - descuento) / ++b4;
          num2 = num1 * this._iva / new Decimal(100);
          num3 = num1 + num2;
        }
        arrayList.Add((object) num1);
        arrayList.Add((object) num2);
        arrayList.Add((object) num3);
      }
      else
        arrayList.Add((object) 1);
      return arrayList;
    }

    public ArrayList totalDescuentoGeneralBoletaFiscal(Decimal descuento, Decimal subtotal)
    {
      ArrayList arrayList = new ArrayList();
      if (subtotal / new Decimal(2) >= descuento)
      {
        Decimal num1;
        Decimal num2;
        Decimal num3;
        if (!this._valoresConIva)
        {
          num1 = subtotal - descuento;
          num2 = num1 * this._iva / new Decimal(100);
          num3 = num1 + num2;
        }
        else
        {
            Decimal b5 = this._iva / new Decimal(100);
          num1 = (subtotal - descuento) / ++b5;
          num2 = num1 * this._iva / new Decimal(100);
          num3 = num1 + num2;
        }
        arrayList.Add((object) num1);
        arrayList.Add((object) num2);
        arrayList.Add((object) num3);
      }
      else
        arrayList.Add((object) 1);
      return arrayList;
    }

    public Decimal porcentajeDescuento(Decimal subtotal, Decimal porcDesc)
    {
      return subtotal * porcDesc / new Decimal(100);
    }

    public Decimal totalSubTotal(List<DatosVentaVO> lista)
    {
      Decimal num = new Decimal(0);
      foreach (DatosVentaVO datosVentaVo in lista)
        num += datosVentaVo.ValorVenta * datosVentaVo.Cantidad;
      return num;
    }

    public Decimal totalNeto(Decimal total)
    {
        Decimal b6 = this._iva / new Decimal(100);
      return total / ++b6;
    }

    public Decimal totalNeto2(List<DatosVentaVO> lista)
    {
      Decimal num = new Decimal(0);
      foreach (DatosVentaVO datosVentaVo in lista)
        num += datosVentaVo.NetoLinea;
      return num;
    }

    public Decimal totalIva(Decimal neto)
    {
      return neto * this._iva / new Decimal(100);
    }

    public ArrayList totalImpuestos(List<DatosVentaVO> lista)
    {
        ArrayList arrayList = new ArrayList();
        Decimal num1 = new Decimal(0);
        Decimal num2 = new Decimal(0);
        Decimal num3 = new Decimal(0);
        Decimal num4 = new Decimal(0);
        Decimal num5 = new Decimal(0);
        Decimal num6 = new Decimal(0);
        Decimal num7 = new Decimal(0);
        Decimal num8 = new Decimal(0);
        Decimal num9 = new Decimal(0);
        Decimal num10 = new Decimal(0);
        int i = 0;
        foreach (DatosVentaVO datosVentaVo in lista)
        {
            if (datosVentaVo.IdImpuesto == 1)
            {
                if (!(lista[i].CodigoImpuesto.Equals("17")))
                {
                    Decimal num11 = datosVentaVo.NetoLinea * this._imp1 / new Decimal(100);
                    num1 += num11;
                }
                else
                {
                    Decimal num11 = calculaOdepa(lista[i].CatCarne, Convert.ToDecimal(lista[i].Cantidad));
                    num1 += num11;

                }
            }
            if (datosVentaVo.IdImpuesto == 2)
            {
                Decimal num11 = datosVentaVo.NetoLinea * this._imp2 / new Decimal(100);
                num2 += num11;
            }
            if (datosVentaVo.IdImpuesto == 3)
            {
                Decimal num11 = datosVentaVo.NetoLinea * this._imp3 / new Decimal(100);
                num3 += num11;
            }
            if (datosVentaVo.IdImpuesto == 4)
            {
                Decimal num11 = datosVentaVo.NetoLinea * this._imp4 / new Decimal(100);
                num4 += num11;
            }
            if (datosVentaVo.IdImpuesto == 5)
            {
                Decimal num11 = datosVentaVo.NetoLinea * this._imp5 / new Decimal(100);
                num5 += num11;
            }
            i++;
        }
        arrayList.Add((object)num1);
        arrayList.Add((object)num2);
        arrayList.Add((object)num3);
        arrayList.Add((object)num4);
        arrayList.Add((object)num5);
        i = 0;
        return arrayList;
    }

    public Decimal totalGeneralBoleta(List<DatosVentaVO> lista)
    {
      Decimal num1 = new Decimal(0);
      bool flag = false;
      Decimal num2 = new Decimal(0);
      Decimal num3 = new Decimal(0);
      Decimal num4 = new Decimal(0);
      Decimal num5 = new Decimal(0);
      Decimal num6 = new Decimal(0);
      foreach (DatosVentaVO datosVentaVo in lista)
      {
        if (!datosVentaVo.Exento)
        {
          num1 += datosVentaVo.TotalLinea;
          if (datosVentaVo.IdImpuesto == 1)
          {
            flag = true;
            num2 = Convert.ToDecimal(this.totalImpuestos(lista)[0].ToString());
          }
          if (datosVentaVo.IdImpuesto == 2)
          {
            flag = true;
            num3 = Convert.ToDecimal(this.totalImpuestos(lista)[1].ToString());
          }
          if (datosVentaVo.IdImpuesto == 3)
          {
            flag = true;
            num4 = Convert.ToDecimal(this.totalImpuestos(lista)[2].ToString());
          }
          if (datosVentaVo.IdImpuesto == 4)
          {
            flag = true;
            num5 = Convert.ToDecimal(this.totalImpuestos(lista)[3].ToString());
          }
          if (datosVentaVo.IdImpuesto == 5)
          {
            flag = true;
            num6 = Convert.ToDecimal(this.totalImpuestos(lista)[4].ToString());
          }
        }
      }
      if (!this._valoresConIva)
      {
          Decimal c3 = this._iva / new Decimal(100);
        num1 *= ++c3;
        if (flag)
          num1 = num1 + num2 + num3 + num4 + num5 + num6;
      }
      return num1;
    }

    public Decimal totalGeneralBoletaExento(List<DatosVentaVO> lista)
    {
      Decimal num = new Decimal(0);
      foreach (DatosVentaVO datosVentaVo in lista)
      {
        if (datosVentaVo.Exento)
          num += datosVentaVo.TotalLinea;
      }
      return num;
    }

    public Decimal totalDescuentoBoleta(List<DatosVentaVO> lista)
    {
      Decimal num = new Decimal(0);
      foreach (DatosVentaVO datosVentaVo in lista)
      {
        if (!datosVentaVo.Exento)
          num += datosVentaVo.Descuento;
      }
      return num;
    }

    public Decimal totalSubTotalBoleta(List<DatosVentaVO> lista)
    {
      Decimal num = new Decimal(0);
      foreach (DatosVentaVO datosVentaVo in lista)
      {
        if (!datosVentaVo.Exento)
          num += Decimal.Round(datosVentaVo.ValorVenta * datosVentaVo.Cantidad);
      }
      return num;
    }

    public Decimal totalGeneralCompra(List<DatosVentaVO> lista)
    {
      Decimal num = new Decimal(0);
      foreach (DatosVentaVO datosVentaVo in lista)
      {
        if (!datosVentaVo.Exento)
          num += (datosVentaVo.TotalLinea - datosVentaVo.ValorCompra );
      }
      Decimal c4 = this._iva / new Decimal(100);
      return num * ++c4;
    }

    public Decimal totalGeneralCompraExento(List<DatosVentaVO> lista)
    {
      Decimal num = new Decimal(0);
      foreach (DatosVentaVO datosVentaVo in lista)
      {
        if (datosVentaVo.Exento)
          num += datosVentaVo.TotalLinea;
      }
      return num;
    }

    public Decimal totalSubTotalCompra(List<DatosVentaVO> lista)
    {
      Decimal num = new Decimal(0);
      foreach (DatosVentaVO datosVentaVo in lista)
      {
        if (!datosVentaVo.Exento)
          num += datosVentaVo.ValorVenta * datosVentaVo.Cantidad;
      }
      return num;
    }

    public Decimal totalGeneralTraspaso(List<DetalleTraspaso> lista)
    {
      Decimal num = new Decimal(0);
      foreach (DetalleTraspaso detalleTraspaso in lista)
        num += detalleTraspaso.TotalLinea;
      Decimal c5 = this._iva / new Decimal(100);
      return num *++c5;
    }

    public ArrayList totalDescuentoGeneralCompra(Decimal descuento, Decimal subtotal)
    {
      ArrayList arrayList = new ArrayList();
      if (descuento < subtotal)
      {
        Decimal num1 = subtotal - descuento;
        Decimal num2 = num1 * this._iva / new Decimal(100);
        Decimal num3 = num1 + num2;
        arrayList.Add((object) num1);
        arrayList.Add((object) num2);
        arrayList.Add((object) num3);
      }
      else
        arrayList.Add((object) 1);
      return arrayList;
    }

    public decimal calculaOdepa(string categoria, Decimal cant)
    {
        CargaMaestros cargamaestro = new CargaMaestros();
        string aux = cargamaestro.traeValorCategria(categoria);

        Decimal valor = Convert.ToDecimal(aux);
        Decimal iva = 0.05m;
        Decimal total = (valor * cant) * iva;

        return total;
    }
  }
}
