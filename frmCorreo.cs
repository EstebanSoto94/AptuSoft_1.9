using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Aptusoft
{
    public partial class frmCorreo : Form
    {
        private CorreoClase claseCorreo = new CorreoClase();

        public frmCorreo()
        {
            InitializeComponent();
        }

        private Boolean emailValido(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(emailValido(txtCorreo.Text))
            {
                claseCorreo.guardaCorreo(txtServCorreo.Text, txtCorreo.Text, txtPass.Text);
                MessageBox.Show("Información Guardada", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Datos Invalidos","Error", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void frmCorreo_Load(object sender, EventArgs e)
        {
            traeCorreo();
        }

        private void traeCorreo()
        {
            DataTable correo = claseCorreo.opcionesCorreo();

            DataRow row = correo.Rows[0];
            txtCorreo.Text = row["correo"].ToString();
            txtPass.Text = row["contrasena"].ToString();
            txtServCorreo.Text = row["servidor_correo"].ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
