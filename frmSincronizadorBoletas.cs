using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aptusoft
{
    public partial class frmSincronizadorBoletas : Form
    {
        public frmSincronizadorBoletas()
        {
            InitializeComponent();
        }
        /**
         * generar query para llena la datagridview y demas
         * */
        public DataTable datos = new DataTable();
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
