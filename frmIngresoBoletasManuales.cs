using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aptusoft.FacturaElectronica.Formularios
{
    public partial class frmInger : Form
    {
        public frmInger()
        {
            InitializeComponent();
        }
        VoIngresoManuales ingresos = new VoIngresoManuales();
        private bool EsExento = false;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                if (subtotal.Text.Length != 0)
                {
                    Decimal[] val = calcular_iva_neto(Convert.ToDecimal(subtotal.Text));
                    TxtNeto.Text = val[0].ToString();
                    TxtIva.Text = val[1].ToString();
                    total.Text = subtotal.Text;
                }
                else
                {
                    txtExento.Clear();
                    TxtIva.Clear();
                    TxtNeto.Clear();
                }
            
        }
        public void iva_neto(bool exento)
        {
            if (exento)
            {
                sumaexento();
            }
            else
            {
                if (subtotal.Text.Length != 0)
                {
                    Decimal[] val = calcular_iva_neto(Convert.ToDecimal(subtotal.Text));

                    TxtNeto.Text = val[0].ToString();

                    TxtIva.Text = val[1].ToString();
                }
                else
                {
                    txtExento.Clear();
                    TxtIva.Clear();
                    TxtNeto.Clear();
                }
            }
        }
        public Decimal[] calcular_iva_neto(Decimal total)
        {
            Decimal iv = new Decimal(0.19);
            Decimal nt = new Decimal(0.81);
            Decimal[] valores = new Decimal[3];
            valores[0] = Decimal.Multiply(total, nt);
            valores[1] = Decimal.Multiply(total, iv);
            return valores;
        }
        public Decimal[] restaExento(Decimal Exenta, Decimal iva)
        {
            Decimal[] valor = new Decimal[2];
            valor[0] = Decimal.Negate(Decimal.Round(Decimal.Subtract( iva,Exenta)));
            valor[1] = Decimal.Round(Decimal.Multiply(Convert.ToDecimal(subtotal.Text), Decimal.Divide(19, 100)));
            return valor;
        }
        private void TxtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        void limpiar()
        {
            txtExento.Clear();
            TxtIva.Clear();
            TxtNeto.Clear();
            subtotal.Clear();
            total.Clear();
            fecha.Value = DateTime.Now;
            comboBox1.SelectedIndex = -1;
            GetFolio();
            btnmodifica.Visible = false;
            btneliminar.Visible = false;
            btnAgregar.Visible = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            string msg = "no debe estar en blanco";
            string msg2 = "Seleciones Tipo  Documento";
            if (comboBox1.SelectedIndex == -1) { errorProvider1.SetError(comboBox1, msg2); comboBox1.Focus(); return; }
            if (subtotal.Text.Length == 0) { errorProvider1.SetError(subtotal, msg); subtotal.Focus(); return; }

            if (MessageBox.Show("Se ingresaran los datos a la base de datos\r\nesta correctos los datos", "AptuSoft", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (TxtNeto.Text == null && txtExento.Text.Length == 0)
                {
                    txtExento.Text = "0";
                }
                string f = fecha.Value.ToString("yyyy-MM-dd HH:mm:ss");
                try
                {
                    ingresos.IngresoManual(textBox1.Text,total.Text, TxtNeto.Text, TxtIva.Text, txtExento.Text, f, comboBox1.SelectedItem.ToString());
                    txtExento.Clear();
                    TxtIva.Clear();
                    TxtNeto.Clear();
                    subtotal.Clear();
                    fecha.Value = DateTime.Now;
                    total.Clear();
                    comboBox1.SelectedIndex = -1;
                    GetFolio();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void frmInger_Load(object sender, EventArgs e)
        {
            GetFolio();
            this.panel1.Visible = false;
        }
        private Conexion conexion = Conexion.getConecta();
        public void GetFolio()
        {
            MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
            ((DbCommand)command).CommandText = "select folio+1 as folio from ingresos_manuales;";
            MySqlDataReader mySqlDataReader = command.ExecuteReader();
            while (((DbDataReader)mySqlDataReader).Read())
            {
                textBox1.Text = mySqlDataReader["folio"].ToString();
            }
            
            mySqlDataReader.Close();
            if (textBox1.Text == "")
            {
                textBox1.Text = "1";
            }
        }
        public void buscar()
        {

        }
        private void buscarRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Visible = true;
            this.button6.Visible = true;
            txtBuscar.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            buscar_porid();
        }
        void buscar_porid()
        {
            if (txtBuscar.Text.Length != 0 && txtBuscar.Text != "")
            {
                //MessageBox.Show(txtBuscar.Text.ToString());
                
                btneliminar.Visible = true;
                btnmodifica.Visible = true;
                btnAgregar.Visible = false;
                recuperainfo();
                txtBuscar.Clear();
                this.panel1.Visible = false;
            }
            else
            {
                MessageBox.Show("debe ingresar numero de ingreso valido", "Alerta", MessageBoxButtons.OK);
            }
        }
        private void recuperainfo()
        {
            try
            {
                DataTable table = new DataTable();
                table = ingresos.recuperaIngreso(Convert.ToInt32(txtBuscar.Text.ToString()));
                DataRow row = table.Rows[0];
                subtotal.Text = row["valor_total"].ToString();
                TxtNeto.Text = row["valor_neto"].ToString();
                TxtIva.Text = row["valor_iva"].ToString();
                txtExento.Text = row["valor_exento"].ToString();
                if (row["tipo"].ToString() == "Boleta")
                {
                    comboBox1.SelectedIndex = 0;
                }
                else
                {
                    comboBox1.SelectedIndex = 1;
                }
                textBox1.Text = row["folio"].ToString();
                fecha.Value = Convert.ToDateTime(row["fecha"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("registro no encotrado", "aptusoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btneliminar.Visible = false;
                btnmodifica.Visible = false;
                btnAgregar.Visible = true;
                this.limpiar();
            }

        }
        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar != 13)
            {
                return;
            }
            else
            {
                buscar_porid();
            }
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.panel1.Visible = false;
            txtBuscar.Clear();
        }

        private void TxtTotal_TextAlignChanged(object sender, EventArgs e)
        {

        }

        private void txtExento_TextChanged(object sender, EventArgs e)
        {
            sumaexento();
            
        }
        void sumaexento()
        {
            try
            {
                Decimal tot = 0;
                Decimal ex = 0;
                if (txtExento.Text.Length != 0) { ex = Convert.ToInt32(txtExento.Text); }
                if (subtotal.Text.Length != 0) { tot = Convert.ToInt32(subtotal.Text); }

                if (tot == 0 && ex == 0)
                {
                    txtExento.Text = "";
                    subtotal.Text = "";
                }
                else
                {
                    total.Text = (Convert.ToInt32(tot) + Convert.ToInt32(ex)).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ex.Message);
            }
        }
        void Restaexento()
        {
            int tot = 0;
            int ex = 0;
            if (txtExento.Text.Length != 0) { ex = Convert.ToInt32(txtExento.Text); }
            if (subtotal.Text.Length != 0) { tot = Convert.ToInt32(subtotal.Text); }

            if (tot == 0 && ex == 0)
            {
                txtExento.Text = "";
                subtotal.Text = "";
            }
            else
            {
                total.Text = (tot - ex).ToString();
            }
        }
        private void txtExento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Back)
            {
                Restaexento();
            }
        }

        private void btnmodifica_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            string msg = "no debe estar en blanco";
            string msg2 = "Seleciones Tipo  Documento";
            if (comboBox1.SelectedIndex == -1) { errorProvider1.SetError(comboBox1, msg2); comboBox1.Focus(); return; }
            if (subtotal.Text.Length == 0) { errorProvider1.SetError(subtotal, msg); subtotal.Focus(); return; }

            if (MessageBox.Show("Se ingresaran los datos a la base de datos\r\nesta correctos los datos", "AptuSoft", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (TxtNeto.Text == null && txtExento.Text.Length == 0)
                {
                    txtExento.Text = "0";
                }
                string f = fecha.Value.ToString("yyyy-MM-dd HH:mm:ss");
                try
                {
                    
                    ingresos.ActualizaIngreso(Convert.ToInt32(textBox1.Text), total.Text, TxtNeto.Text, TxtIva.Text, txtExento.Text, f, comboBox1.SelectedItem.ToString());
                    txtExento.Clear();
                    TxtIva.Clear();
                    TxtNeto.Clear();
                    subtotal.Clear();
                    fecha.Value = DateTime.Now;
                    total.Clear();
                    comboBox1.SelectedIndex = -1;
                    GetFolio();
                    btnAgregar.Visible = true;
                    btneliminar.Visible = false;
                    btnmodifica.Visible = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Esta Seguro de eliminar El Registro", "AptuSoft", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (TxtNeto.Text == null && txtExento.Text.Length == 0)
                {
                    txtExento.Text = "0";
                }
                string f = fecha.Value.ToString("yyyy-MM-dd HH:mm:ss");
                try
                {
                    ingresos.EliminaIngreso(Convert.ToInt32(textBox1.Text));
                    txtExento.Clear();
                    TxtIva.Clear();
                    TxtNeto.Clear();
                    subtotal.Clear();
                    fecha.Value = DateTime.Now;
                    comboBox1.SelectedIndex = -1;
                    total.Clear();
                    GetFolio();
                    btnAgregar.Visible = true;
                    btneliminar.Visible = false;
                    btnmodifica.Visible = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void txtExento_Enter(object sender, EventArgs e)
        {
        }
    }

}