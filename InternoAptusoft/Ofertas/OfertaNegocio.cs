 
// Type: Aptusoft.InternoAptusoft.Ofertas.OfertaNegocio
 
 
// version 1.8.0

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Aptusoft.InternoAptusoft.Ofertas
{
  public class OfertaNegocio
  {
    public void GuardaOferta(OfertaVO of)
    {
      if (!this.ValidaOferta(of))
        return;
      try
      {
        if (of.IdOferta == 0)
        {
          new Oferta().GuardaOferta(of);
          int num = (int) MessageBox.Show("Oferta Guardada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        else
        {
          new Oferta().ModificaOferta(of);
          int num = (int) MessageBox.Show("Oferta Modificada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al Guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private bool ValidaOferta(OfertaVO of)
    {
      if (of.CodigoOferta.Trim().Length == 0)
      {
        int num = (int) MessageBox.Show("Debe Ingresar un Codigo de Oferta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        return false;
      }
      if (of.Nombre.Trim().Length == 0)
      {
        int num = (int) MessageBox.Show("Debe Ingresar un Nombre de Oferta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        return false;
      }
      if (of.Descripcion.Trim().Length != 0)
        return true;
      int num1 = (int) MessageBox.Show("Debe Ingresar una Descripcion de Oferta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      return false;
    }

    public bool ValidaOfertaPorCodigoExiste(List<OfertaVO> lista, string codigo)
    {
      bool flag = false;
      foreach (OfertaVO ofertaVo in lista)
      {
        if (ofertaVo.CodigoOferta.Equals(codigo))
        {
          flag = true;
          break;
        }
      }
      return flag;
    }

    public void EliminaOferta(int id)
    {
      if (id > 0)
      {
        new Oferta().EliminaOferta(id);
        int num = (int) MessageBox.Show("Oferta Eliminada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      else
      {
        int num1 = (int) MessageBox.Show("No Existe Oferta Seleccionada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    public OfertaVO BuscaOfertaPorIdEnLista(List<OfertaVO> lista, int idOferta)
    {
      OfertaVO ofertaVo = new OfertaVO();
      return lista.Find((Predicate<OfertaVO>) (x => x.IdOferta == idOferta));
    }

    public List<OfertaVO> ListaOfertas()
    {
      return new Oferta().ListaOfertas();
    }

    public List<OfertaVO> ListaOfertasVigentes()
    {
      return new Oferta().ListaOfertasVigentes();
    }
  }
}
