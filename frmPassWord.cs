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
    public partial class frmPassWord : Form
    {
        public frmPassWord()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmConfSync a = new FrmConfSync();
            a.contra = textBox1.Text;
            this.Close();
        }
    }
}
