using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aptusoft.Maquinaria
{
    public partial class frmEstado : Form
    {
        private Estado es = new Estado();
        private int idEs = 0;
        private bool _guarda = false;
        private bool _modifica = false;
        private bool _elimina = false;

        public frmEstado()
        {
            InitializeComponent();
            iniciaFormulario();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal._modEstadosMaquinaria = 0;
            this.Close();
            this.Dispose();
        }

        private void frmEstado_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMenuPrincipal._modEstadosMaquinaria = 0;
            this.Dispose();
        }

        private bool validaFormulario()
        {
            if (this.txtNombre.Text.Trim().Length != 0)
                return true;
            int num = (int)MessageBox.Show("Debe Ingresar el Nombre del Estado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            this.txtNombre.Focus();
            return false;
        }

        public void iniciaFormulario()
        {
            this.idEs = 0;
            this.dgvDatos.DataSource = (object)this.es.listaEstados().Tables[0];
            this.txtNombre.Clear();
            this.txtNombre.Focus();
            if (!this._guarda)
                this.btnGuardar.Enabled = true;
            else
                this.btnGuardar.Enabled = false;
            this.btnModificar.Enabled = false;
            this.btnEliminar.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!this.validaFormulario())
                return;
            EstadoVO esVO = new EstadoVO();
            esVO.estado = this.txtNombre.Text.Trim().ToUpper();
            
            try
            {
                this.es.agregarEstado(esVO);
                int num = (int)MessageBox.Show("Estado Guardado Correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.iniciaFormulario();
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show("Error al Guardar: " + ex.Message);
            }
        }

        private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.idEs = Convert.ToInt32(this.dgvDatos.SelectedRows[0].Cells[0].Value.ToString());
            EstadoVO estadoVO = this.es.buscaEstadoId(this.idEs);
            this.idEs = estadoVO.idEstado;
            this.txtNombre.Text = estadoVO.estado;
            if (!this._modifica)
                this.btnModificar.Enabled = true;
            if (!this._elimina)
                this.btnEliminar.Enabled = true;
            this.btnGuardar.Enabled = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            iniciaFormulario();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta Seguro de Modificar el Estado", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes || !this.validaFormulario())
                return;
            EstadoVO esVO = new EstadoVO();
            esVO.idEstado = this.idEs;
            esVO.estado = this.txtNombre.Text.Trim().ToUpper();
            try
            {
                this.es.modificaEstado(esVO);
                int num = (int)MessageBox.Show("Estado Modificado Correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.iniciaFormulario();
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show("Error al Modificar: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta Seguro de Eliminar el Estado", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            try
            {
                this.es.eliminaEstado(this.idEs);
                int num = (int)MessageBox.Show("Estado Eliminado Correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.iniciaFormulario();
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show("Error al Eliminar: " + ex.Message);
            }
        }


    }
}
