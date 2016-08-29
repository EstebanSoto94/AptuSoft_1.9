 
// Type: Aptusoft.InternoAptusoft.Contratacion.ContratoNegocio
 
 
// version 1.8.0

using Aptusoft;
using Aptusoft.InternoAptusoft.Facturacion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Aptusoft.InternoAptusoft.Contratacion
{
  public class ContratoNegocio
  {
    public int GuardaContrato(ContratoVO co)
    {
      try
      {
        return new Contrato().GuardaContrato(co);
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al Guardar " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        return 0;
      }
    }

    public void ModificaContrato(ContratoVO co)
    {
      new Contrato().ModificaContrato(co);
    }

    public int GuardaContratoCambioCiclo(ContratoVO co)
    {
      try
      {
        return new Contrato().GuardaContratoCambioCiclo(co);
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al Guardar Cambio de Ciclo" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        return 0;
      }
    }

    public DataTable MuestraContratoID(int idContrato)
    {
      if (idContrato > 0)
        return new Contrato().MuestraContratoID(idContrato);
      return (DataTable) null;
    }

    public ContratoVO BuscaContratoActivoIdCliente(int idCliente)
    {
      if (idCliente > 0)
        return new Contrato().BuscaContratoActivoIdCliente(idCliente);
      return (ContratoVO) null;
    }

    public List<ContratoVO> BuscaContratoActivoCodigoCiclo(string consulta, DateTime fechaFacturacion)
    {
      if (consulta.Trim().Length <= 0)
        return (List<ContratoVO>) null;
      List<ContratoVO> list1 = new Contrato().BuscaContratoActivoCodigoCiclo(consulta);
      List<ContratoVO> list2 = new List<ContratoVO>();
      FacturacionNegocio facturacionNegocio = new FacturacionNegocio();
      if (list1.Count > 0)
      {
        foreach (ContratoVO co in list1)
        {
          if (!facturacionNegocio.BuscaContratoFacturadoAlgunaVez(co.IdContrato))
          {
            co.Facturar = true;
            co.Email = new Cliente().buscaEmailCliente(co.IdCliente);
            ContratoVO contratoVo = this.BuscaPrecioYCalculoMesesOferta(co);
            list2.Add(contratoVo);
          }
          else if (fechaFacturacion >= co.SegundaFacturacion && !facturacionNegocio.BuscaContratoFacturado(co.IdContrato, fechaFacturacion))
          {
            co.Facturar = true;
            co.Email = new Cliente().buscaEmailCliente(co.IdCliente);
            ContratoVO contratoVo = this.BuscaPrecioYCalculoMesesOferta(co);
            list2.Add(contratoVo);
          }
        }
      }
      return list2;
    }

    private ContratoVO BuscaPrecioYCalculoMesesOferta(ContratoVO co)
    {
      ProductoVO productoVo = new Producto().buscaCodigoProducto(co.Codigo);
      co.SubTotal = productoVo.ValorVenta1;
      if (co.MesesOferta > 0)
      {
        co.MesesOfertaRestante = co.MesesOferta - co.MesesOfertaOcupado;
        if (co.MesesOfertaRestante == 0)
        {
          co.Descuento = new Decimal(0);
          co.Total = co.SubTotal;
          co.DescuentoOferta = new Decimal(0);
        }
        else if (co.DescuentoOferta > new Decimal(0))
        {
          if (co.DescuentoOferta == new Decimal(100))
          {
            co.Descuento = co.SubTotal;
            co.Total = new Decimal(0);
          }
          else
          {
            co.Descuento = co.SubTotal * co.DescuentoOferta / new Decimal(100);
            co.Total = co.SubTotal - co.Descuento;
          }
        }
      }
      else
      {
        co.MesesOfertaRestante = 0;
        co.Total = co.SubTotal;
      }
      return co;
    }

    public void ModificaMesesOfertaOcupado(int idContrato)
    {
      new Contrato().ModificaMesesOfertaOcupado(idContrato);
    }

    public List<ContratoVO> BuscaContratoIdCliente(int idCliente)
    {
      return new Contrato().BuscaContratoIdCliente(idCliente);
    }
  }
}
