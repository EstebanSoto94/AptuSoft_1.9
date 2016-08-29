 
// Type: Aptusoft.frmSeleccionaListaPreciocs
 
 
// version 1.8.0

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Aptusoft
{
  public class frmSeleccionaListaPreciocs : Form
  {
    private IContainer components = (IContainer) null;
    private Decimal _lista1 = new Decimal(0);
    private Decimal _lista2 = new Decimal(0);
    private Decimal _lista3 = new Decimal(0);
    private frmBoletaFiscal bolFiscal = (frmBoletaFiscal) null;
    private frmBoleta boleta = (frmBoleta) null;
    private frmFactura factura = (frmFactura) null;
    private TextBox txtLista1;
    private Label label13;
    private TextBox txtLista2;
    private Label label1;
    private TextBox txtLista3;
    private Label label2;
    private TextBox txtListaSeleccionada;
    private Label label3;
    private Label label4;
    private Label label5;
    private Label label6;
    private Label label7;
    private Label label8;

    public frmSeleccionaListaPreciocs(Decimal l1, Decimal l2, Decimal l3, ref frmBoletaFiscal bf)
    {
      this.InitializeComponent();
      this._lista1 = l1;
      this._lista2 = l2;
      this._lista3 = l3;
      this.bolFiscal = bf;
      this.iniciaFormulario();
    }

    public frmSeleccionaListaPreciocs(Decimal l1, Decimal l2, Decimal l3, ref frmBoleta b)
    {
      this.InitializeComponent();
      this._lista1 = l1;
      this._lista2 = l2;
      this._lista3 = l3;
      this.boleta = b;
      this.iniciaFormulario();
    }

    public frmSeleccionaListaPreciocs(Decimal l1, Decimal l2, Decimal l3, ref frmFactura f)
    {
      this.InitializeComponent();
      this._lista1 = l1;
      this._lista2 = l2;
      this._lista3 = l3;
      this.factura = f;
      this.iniciaFormulario();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.txtLista1 = new TextBox();
      this.label13 = new Label();
      this.txtLista2 = new TextBox();
      this.label1 = new Label();
      this.txtLista3 = new TextBox();
      this.label2 = new Label();
      this.txtListaSeleccionada = new TextBox();
      this.label3 = new Label();
      this.label4 = new Label();
      this.label5 = new Label();
      this.label6 = new Label();
      this.label7 = new Label();
      this.label8 = new Label();
      this.SuspendLayout();
      this.txtLista1.BackColor = Color.White;
      this.txtLista1.BorderStyle = BorderStyle.FixedSingle;
      this.txtLista1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtLista1.Location = new Point(2, 23);
      this.txtLista1.Name = "txtLista1";
      this.txtLista1.ReadOnly = true;
      this.txtLista1.Size = new Size(101, 22);
      this.txtLista1.TabIndex = 1;
      this.txtLista1.TextAlign = HorizontalAlignment.Center;
      this.label13.BackColor = Color.FromArgb(64, 64, 64);
      this.label13.ForeColor = Color.White;
      this.label13.Location = new Point(2, 9);
      this.label13.Name = "label13";
      this.label13.Size = new Size(101, 23);
      this.label13.TabIndex = 10;
      this.label13.Text = "Lista 1";
      this.label13.TextAlign = ContentAlignment.TopCenter;
      this.txtLista2.BackColor = Color.White;
      this.txtLista2.BorderStyle = BorderStyle.FixedSingle;
      this.txtLista2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtLista2.Location = new Point(109, 23);
      this.txtLista2.Name = "txtLista2";
      this.txtLista2.ReadOnly = true;
      this.txtLista2.Size = new Size(101, 22);
      this.txtLista2.TabIndex = 2;
      this.txtLista2.TextAlign = HorizontalAlignment.Center;
      this.label1.BackColor = Color.FromArgb(64, 64, 64);
      this.label1.ForeColor = Color.White;
      this.label1.Location = new Point(109, 9);
      this.label1.Name = "label1";
      this.label1.Size = new Size(101, 23);
      this.label1.TabIndex = 12;
      this.label1.Text = "Lista 2";
      this.label1.TextAlign = ContentAlignment.TopCenter;
      this.txtLista3.BackColor = Color.White;
      this.txtLista3.BorderStyle = BorderStyle.FixedSingle;
      this.txtLista3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtLista3.Location = new Point(216, 23);
      this.txtLista3.Name = "txtLista3";
      this.txtLista3.ReadOnly = true;
      this.txtLista3.Size = new Size(101, 22);
      this.txtLista3.TabIndex = 3;
      this.txtLista3.TextAlign = HorizontalAlignment.Center;
      this.label2.BackColor = Color.FromArgb(64, 64, 64);
      this.label2.ForeColor = Color.White;
      this.label2.Location = new Point(216, 9);
      this.label2.Name = "label2";
      this.label2.Size = new Size(101, 23);
      this.label2.TabIndex = 14;
      this.label2.Text = "Lista 3";
      this.label2.TextAlign = ContentAlignment.TopCenter;
      this.txtListaSeleccionada.Font = new Font("Microsoft Sans Serif", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtListaSeleccionada.Location = new Point(217, 111);
      this.txtListaSeleccionada.MaxLength = 1;
      this.txtListaSeleccionada.Name = "txtListaSeleccionada";
      this.txtListaSeleccionada.Size = new Size(100, 35);
      this.txtListaSeleccionada.TabIndex = 0;
      this.txtListaSeleccionada.TextAlign = HorizontalAlignment.Center;
      this.txtListaSeleccionada.KeyDown += new KeyEventHandler(this.txtListaSeleccionada_KeyDown);
      this.txtListaSeleccionada.KeyPress += new KeyPressEventHandler(this.txtListaSeleccionada_KeyPress);
      this.label3.AutoSize = true;
      this.label3.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label3.Location = new Point(63, 119);
      this.label3.Name = "label3";
      this.label3.Size = new Size(148, 15);
      this.label3.TabIndex = 16;
      this.label3.Text = "INGRESE N° OPCION:";
      this.label3.TextAlign = ContentAlignment.TopCenter;
      this.label4.AutoSize = true;
      this.label4.Location = new Point(2, 48);
      this.label4.Name = "label4";
      this.label4.Size = new Size(65, 13);
      this.label4.TabIndex = 17;
      this.label4.Text = "Opción N° 1";
      this.label5.AutoSize = true;
      this.label5.Location = new Point((int) sbyte.MaxValue, 48);
      this.label5.Name = "label5";
      this.label5.Size = new Size(0, 13);
      this.label5.TabIndex = 18;
      this.label6.AutoSize = true;
      this.label6.Location = new Point(109, 48);
      this.label6.Name = "label6";
      this.label6.Size = new Size(65, 13);
      this.label6.TabIndex = 19;
      this.label6.Text = "Opción N° 2";
      this.label7.AutoSize = true;
      this.label7.Location = new Point(216, 48);
      this.label7.Name = "label7";
      this.label7.Size = new Size(65, 13);
      this.label7.TabIndex = 20;
      this.label7.Text = "Opción N° 3";
      this.label8.AutoSize = true;
      this.label8.Location = new Point(148, 155);
      this.label8.Name = "label8";
      this.label8.Size = new Size(169, 13);
      this.label8.TabIndex = 21;
      this.label8.Text = "Pulse la tecla Enter para continuar";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(223, 233, 245);
      this.ClientSize = new Size(320, 171);
      this.Controls.Add((Control) this.label8);
      this.Controls.Add((Control) this.label7);
      this.Controls.Add((Control) this.label6);
      this.Controls.Add((Control) this.label5);
      this.Controls.Add((Control) this.label4);
      this.Controls.Add((Control) this.txtListaSeleccionada);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.txtLista3);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.txtLista2);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.txtLista1);
      this.Controls.Add((Control) this.label13);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Name = "frmSeleccionaListaPreciocs";
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Seleccion de Lista de Preciocios";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private void iniciaFormulario()
    {
      this.txtLista1.Clear();
      this.txtLista2.Clear();
      this.txtLista3.Clear();
      this.txtListaSeleccionada.Clear();
      this.txtLista1.Text = this._lista1.ToString("N0");
      this.txtLista2.Text = this._lista2.ToString("N0");
      this.txtLista3.Text = this._lista3.ToString("N0");
      this.txtListaSeleccionada.Focus();
    }

    private void txtListaSeleccionada_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      if (this.txtListaSeleccionada.Text.Trim().Length > 0)
      {
        if (this.txtListaSeleccionada.Text == "1" || this.txtListaSeleccionada.Text == "2" || this.txtListaSeleccionada.Text == "3")
        {
          if (this.bolFiscal != null)
          {
            this.bolFiscal.seleccionaListaPrecios(Convert.ToInt32(this.txtListaSeleccionada.Text.Trim()));
            this.Close();
          }
          if (this.boleta != null)
          {
            this.boleta.seleccionaListaPrecios(Convert.ToInt32(this.txtListaSeleccionada.Text.Trim()));
            this.Close();
          }
          if (this.factura != null)
          {
            this.factura.seleccionaListaPrecios(Convert.ToInt32(this.txtListaSeleccionada.Text.Trim()));
            this.Close();
          }
        }
        else
        {
          int num = (int) MessageBox.Show("Solo Se Permiten las opciones 1, 2 y 3]", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          this.txtListaSeleccionada.Focus();
        }
      }
      else
      {
        int num = (int) MessageBox.Show("Debe Ingresar Un Numero de Lista [1-2-3]", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.txtListaSeleccionada.Focus();
      }
    }

    private void soloNumeros(KeyPressEventArgs e, TextBox caja)
    {
      if ((int) e.KeyChar == 8)
        e.Handled = false;
      else if ((int) e.KeyChar >= 49 && (int) e.KeyChar <= 51)
        e.Handled = false;
      else
        e.Handled = true;
    }

    private void txtListaSeleccionada_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtListaSeleccionada);
    }
  }
}
