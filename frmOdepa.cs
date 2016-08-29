using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aptusoft
{
    public partial class frmOdepa : Form
    {
        private Odepa ven = new Odepa();
        private int idOd = 0;
        private bool _guarda = false;
        private bool _modifica = false;
        private bool _elimina = false;
        

        public frmOdepa()
        {
            InitializeComponent();
        }

        private void frmOdepa_Load(object sender, EventArgs e)
        {
            this.iniciaFormulario();
        }

        public void iniciaFormulario()
        {
            this.idOd = 0;
            this.dgvDatos.DataSource = (object)this.ven.listaCategoria().Tables[0];
            this.txtNombreCat.Clear();
            this.txtValor.Clear();
            this.txtNombreCat.Focus();

            this.btnGuardar.Enabled = true;

            this.btnGuardar.Enabled = true;
            this.btnModificar.Enabled = true;
            this.btnEliminar.Enabled = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal._modOdepa = 0;
            this.Close();
            this.Dispose();
        }

        private void frmOdepa_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMenuPrincipal._modOdepa = 0;
            this.Dispose();
        }
        private bool validaFormulario()
        {
            if (this.txtNombreCat.Text.Trim().Length != 0)
                return true;
            int num = (int)MessageBox.Show("Debe Ingresar el Nombre de la Categoría", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            this.txtNombreCat.Focus();
            return false;
        }

        private void soloNumeros(KeyPressEventArgs e, TextBox caja)
        {
            if ((int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                bool flag = false;
                int num = 0;
                for (int index = 0; index < caja.Text.Length; ++index)
                {
                    if ((int)caja.Text[index] == 44)
                        flag = true;
                    if (flag && num++ >= 4)
                    {
                        e.Handled = true;
                        return;
                    }
                }
                if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57)
                    e.Handled = false;
                else if ((int)e.KeyChar == 44)
                    e.Handled = flag;
                else
                    e.Handled = true;
            }
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.soloNumeros(e, this.txtValor);
        }

        private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.idOd = Convert.ToInt32(this.dgvDatos.SelectedRows[0].Cells[0].Value.ToString());
            OdepaVO odepaVo = this.ven.buscaCategoriaId(this.idOd);
            this.idOd = odepaVo.id;
            this.txtNombreCat.Text = odepaVo.nombre_cat;
            this.txtValor.Text = odepaVo.valor.ToString();
            if (this._modifica)
                this.btnModificar.Enabled = true;
            if (this._elimina)
                this.btnEliminar.Enabled = true;
            this.btnGuardar.Enabled = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.iniciaFormulario();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta Seguro de Modificar la Categoría", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes || !this.validaFormulario())
                return;
            OdepaVO odepaVo = new OdepaVO();
            odepaVo.id = this.idOd;
            odepaVo.nombre_cat = this.txtNombreCat.Text.Trim().ToUpper();
            odepaVo.valor = this.txtValor.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtValor.Text.Trim()) : new Decimal(0);
            try
            {
                this.ven.modificaValor(odepaVo);
                int num = (int)MessageBox.Show("Categoría Modificada Correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.iniciaFormulario();
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show("Error al Modificar: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta Seguro de Eliminar la Categoría", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            try
            {
                this.ven.eliminaCategoria(this.idOd);
                int num = (int)MessageBox.Show("Categoría Eliminada Correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.iniciaFormulario();
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show("Error al Eliminar: " + ex.Message);
            }
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (!this.validaFormulario())
                return;
            OdepaVO od = new OdepaVO();
            od.nombre_cat = this.txtNombreCat.Text.Trim().ToUpper();
            od.valor = this.txtValor.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtValor.Text.Trim()) : new Decimal(0);
            try
            {
                this.ven.agregaCategoria(od);
                int num = (int)MessageBox.Show("Categoría Guardada Correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.iniciaFormulario();
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show("Error al Guardar: " + ex.Message);
            }
        }
    }
}
