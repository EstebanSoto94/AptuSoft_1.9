using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aptusoft.Properties;
using System.Collections;
using System.IO;

namespace Aptusoft.Maquinaria
{
    public partial class frmMaquinaria : Form
    {
        MaquinariaVO maquinariaVO = new MaquinariaVO();
        Maquinaria ma = new Maquinaria();
        private int _codEncontrado = 0;

        public frmMaquinaria()
        {
            InitializeComponent();
        }

        private void frmMaquinaria_Load(object sender, EventArgs e)
        {
            cargaEstados();
        }

        private void cargaEstados()
        {
            DataTable estados = new DataTable();
            try
            {
                estados = new Estado().listaEstadosMaquinaria();

                this.cboEstados.DataSource = estados;
                this.cboEstados.DisplayMember = "estado";
                this.cboEstados.ValueMember = "idEstado";
                this.cboEstados.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los Estados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!validaCampos())
                return;
            llenaCampos();
            try
            {
                guardaMaquina();
                MessageBox.Show("Datos Guardados Correctamente","Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocurrió un error al intentar Guardar: " + ex.ToString(),"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            limpiar();
        }

        private void guardaMaquina()
        {
            maquinariaVO.codigo = txtCodigo.Text.Trim();
            maquinariaVO.descripcion = txtDescripcion.Text.Trim();
            maquinariaVO.nombre = txtNombre.Text.Trim();
            maquinariaVO.valor = Convert.ToDecimal(txtValor.Text.Trim());
            maquinariaVO.idEstado = Convert.ToInt32(cboEstados.SelectedValue.ToString());
            maquinariaVO.estado = cboEstados.Text.ToString().Trim();
            maquinariaVO.bod_1 = Convert.ToInt32(txtBod1.Text.Trim());
            maquinariaVO.bod_2 = Convert.ToInt32(txtBod2.Text.Trim());
            maquinariaVO.bod_3 = Convert.ToInt32(txtBod3.Text.Trim());
            maquinariaVO.bod_4 = Convert.ToInt32(txtBod4.Text.Trim());
            maquinariaVO.bod_5 = Convert.ToInt32(txtBod5.Text.Trim());
            maquinariaVO.bod_6 = Convert.ToInt32(txtBod6.Text.Trim());
            maquinariaVO.bod_7 = Convert.ToInt32(txtBod7.Text.Trim());
            maquinariaVO.bod_8 = Convert.ToInt32(txtBod8.Text.Trim());
            maquinariaVO.bod_9 = Convert.ToInt32(txtBod9.Text.Trim());
            maquinariaVO.bod_10 = Convert.ToInt32(txtBod10.Text.Trim());

            ma.agregaMaquinaria(maquinariaVO);
            cambiaEnabledFalse();

        }

        private void llenaCampos()
        {
            if(txtBod1.Text.Length == 0)
            {
                txtBod1.Text = "0";
            }
            if (txtBod2.Text.Length == 0)
            {
                txtBod2.Text = "0";
            }
            if (txtBod3.Text.Length == 0)
            {
                txtBod3.Text = "0";
            }
            if (txtBod4.Text.Length == 0)
            {
                txtBod4.Text = "0";
            }
            if (txtBod5.Text.Length == 0)
            {
                txtBod5.Text = "0";
            }
            if (txtBod6.Text.Length == 0)
            {
                txtBod6.Text = "0";
            }
            if (txtBod7.Text.Length == 0)
            {
                txtBod7.Text = "0";
            }
            if (txtBod8.Text.Length == 0)
            {
                txtBod8.Text = "0";
            }
            if (txtBod9.Text.Length == 0)
            {
                txtBod9.Text = "0";
            }
            if (txtBod10.Text.Length == 0)
            {
                txtBod10.Text = "0";
            }
            if(txtDescripcion.Text.Trim().Length == 0)
            {
                txtDescripcion.Text = "";
            }
        }

        private Boolean validaCampos()
        {
            if(txtCodigo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe Ingresar un Código","Datos Erroneos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCodigo.Focus();
                return false;
            }
            if (txtNombre.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe Ingresar un Nombre", "Datos Erroneos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombre.Focus();
                return false;
            }
            if (txtValor.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe Ingresar un Valor Diario", "Datos Erroneos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtValor.Focus();
                return false;
            }
            return true;
        }

        private void limpiar()
        {

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtValor.Text = "";
            txtBod1.Text = "";
            txtBod2.Text = "";
            txtBod3.Text = "";
            txtBod4.Text = "";
            txtBod5.Text = "";
            txtBod6.Text = "";
            txtBod7.Text = "";
            txtBod8.Text = "";
            txtBod9.Text = "";
            txtBod10.Text = "";
            cargaEstados();
            btnGuardar.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnLimpiar.Enabled = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cambiaEnabledFalse();
            limpiar();
        }

        private void txtCodigo_Enter(object sender, EventArgs e)
        {
            
        }

        private void buscarMaquinaria(string cod)
        {
            maquinariaVO = ma.buscaCodigoMaquinaria(cod);
            if (maquinariaVO.codigo == null)
            {
                this._codEncontrado = 1;
                int num = (int)MessageBox.Show("El Producto No Existe", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                string str = cod;
                //this.iniciaProducto();
                this.txtCodigo.Text = str;
                this.btnGuardar.Enabled = true;
                this.btnEliminar.Enabled = false;
                this.btnModificar.Enabled = false;
                cambiaEnabled();
            }else
            {
                this.txtCodigo.Text = maquinariaVO.codigo;
                this.txtNombre.Text = maquinariaVO.nombre;
                this.txtDescripcion.Text = maquinariaVO.descripcion;
                this.txtValor.Text = maquinariaVO.valor.ToString("N4");
                this.txtBod1.Text = maquinariaVO.bod_1.ToString("N4");
                this.txtBod2.Text = maquinariaVO.bod_2.ToString("N4");
                this.txtBod3.Text = maquinariaVO.bod_3.ToString("N4");
                this.txtBod4.Text = maquinariaVO.bod_4.ToString("N4");
                this.txtBod5.Text = maquinariaVO.bod_5.ToString("N4");
                this.txtBod6.Text = maquinariaVO.bod_6.ToString("N4");
                this.txtBod7.Text = maquinariaVO.bod_7.ToString("N4");
                this.txtBod8.Text = maquinariaVO.bod_8.ToString("N4");
                this.txtBod9.Text = maquinariaVO.bod_9.ToString("N4");
                this.txtBod10.Text = maquinariaVO.bod_10.ToString("N4");
                this.cboEstados.SelectedValue = maquinariaVO.idEstado;
                this.btnGuardar.Enabled = false;
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
                btnLimpiar.Enabled = true;
                cambiaEnabled();
                this._codEncontrado = 0;
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar != 13)
                return;
            e.Handled = false;
            if (!(this.txtCodigo.Text == string.Empty))
            {
                buscarMaquinaria(this.txtCodigo.Text);
            }
        }

        private void cambiaEnabled()
        {
            this.txtNombre.Enabled = true;
            this.txtDescripcion.Enabled = true;
            this.txtValor.Enabled = true;
            this.txtBod1.Enabled = true;
            this.txtBod2.Enabled = true;
            this.txtBod3.Enabled = true;
            this.txtBod4.Enabled = true;
            this.txtBod5.Enabled = true;
            this.txtBod6.Enabled = true;
            this.txtBod7.Enabled = true;
            this.txtBod8.Enabled = true;
            this.txtBod9.Enabled = true;
            this.txtBod10.Enabled = true;
            this.cboEstados.Enabled = true;
        }

        private void cambiaEnabledFalse()
        {
            this.txtNombre.Enabled = false;
            this.txtDescripcion.Enabled = false;
            this.txtValor.Enabled = false;
            this.txtBod1.Enabled = false;
            this.txtBod2.Enabled = false;
            this.txtBod3.Enabled = false;
            this.txtBod4.Enabled = false;
            this.txtBod5.Enabled = false;
            this.txtBod6.Enabled = false;
            this.txtBod7.Enabled = false;
            this.txtBod8.Enabled = false;
            this.txtBod9.Enabled = false;
            this.txtBod10.Enabled = false;
            this.cboEstados.Enabled = false;
        }
    }
}
