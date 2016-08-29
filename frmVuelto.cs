 
// Type: Aptusoft.frmVuelto
 
 
// version 1.8.0

using Aptusoft.FacturaElectronica.Formularios;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Aptusoft
{
  public class frmVuelto : Form
  {
    private IContainer components = (IContainer) null;
    private bool puedeSalir = false;
    private frmBoleta frmBol = (frmBoleta) null;
    private frmBoletaFiscal frmBolFis = (frmBoletaFiscal) null;
    private frmFactura frmFac = (frmFactura) null;
    private frmFacturaExenta frmFacExe = (frmFacturaExenta) null;
    private frmNotaVenta frmNV = (frmNotaVenta) null;
    private frmFacturaElectronica frmFacElectronic = (frmFacturaElectronica) null;
    private frmFacturaElectronicaFrigo frmFacElecFrigo = (frmFacturaElectronicaFrigo)null;
    private frmBoletaElectronica frmBoletaElectronic = (frmBoletaElectronica) null;
    private string modulo = "";
    private Label label1;
    private Label label2;
    private Label label3;
    private TextBox txtTotalPagar;
    private TextBox txtPagaCon;
    private TextBox txtVuelto;
    private Label label4;

    public frmVuelto()
    {
      this.InitializeComponent();
      this.iniciaFormulario();
    }

    public frmVuelto(string tp, ref frmBoleta b, string mod)
    {
      this.InitializeComponent();
      if (tp.Length > 0)
        this.txtTotalPagar.Text = tp;
      else
        this.txtTotalPagar.Text = "0";
      this.iniciaFormulario();
      this.modulo = mod;
      this.frmBol = b;
    }

    public frmVuelto(string tp, ref frmBoletaFiscal b, string mod)
    {
      this.InitializeComponent();
      if (tp.Length > 0)
        this.txtTotalPagar.Text = tp;
      else
        this.txtTotalPagar.Text = "0";
      this.iniciaFormulario();
      this.modulo = mod;
      this.frmBolFis = b;
    }

    public frmVuelto(string tp, ref frmFactura f, string mod)
    {
      this.InitializeComponent();
      if (tp.Length > 0)
        this.txtTotalPagar.Text = tp;
      else
        this.txtTotalPagar.Text = "0";
      this.iniciaFormulario();
      this.modulo = mod;
      this.frmFac = f;
    }

    public frmVuelto(string tp, ref frmFacturaElectronica f, string mod)
    {
      this.InitializeComponent();
      if (tp.Length > 0)
        this.txtTotalPagar.Text = tp;
      else
        this.txtTotalPagar.Text = "0";
      this.iniciaFormulario();
      this.modulo = mod;
      this.frmFacElectronic = f;
    }

    public frmVuelto(string tp, ref frmFacturaElectronicaFrigo f, string mod)
    {
        this.InitializeComponent();
        if (tp.Length > 0)
            this.txtTotalPagar.Text = tp;
        else
            this.txtTotalPagar.Text = "0";
        this.iniciaFormulario();
        this.modulo = mod;
        this.frmFacElecFrigo = f;
    }

    public frmVuelto(string tp, ref frmBoletaElectronica b, string mod)
    {
      this.InitializeComponent();
      if (tp.Length > 0)
        this.txtTotalPagar.Text = tp;
      else
        this.txtTotalPagar.Text = "0";
      this.iniciaFormulario();
      this.modulo = mod;
      this.frmBoletaElectronic = b;
    }

    public frmVuelto(string tp, ref frmFacturaExenta fe, string mod)
    {
      this.InitializeComponent();
      if (tp.Length > 0)
        this.txtTotalPagar.Text = tp;
      else
        this.txtTotalPagar.Text = "0";
      this.iniciaFormulario();
      this.modulo = mod;
      this.frmFacExe = fe;
    }

    public frmVuelto(string tp, ref frmNotaVenta nv, string mod)
    {
      this.InitializeComponent();
      if (tp.Length > 0)
        this.txtTotalPagar.Text = tp;
      else
        this.txtTotalPagar.Text = "0";
      this.iniciaFormulario();
      this.modulo = mod;
      this.frmNV = nv;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.label1 = new Label();
      this.label2 = new Label();
      this.label3 = new Label();
      this.txtTotalPagar = new TextBox();
      this.txtPagaCon = new TextBox();
      this.txtVuelto = new TextBox();
      this.label4 = new Label();
      this.SuspendLayout();
      this.label1.AutoSize = true;
      this.label1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label1.Location = new Point(6, 38);
      this.label1.Name = "label1";
      this.label1.Size = new Size(116, 20);
      this.label1.TabIndex = 0;
      this.label1.Text = "Total a Pagar";
      this.label2.AutoSize = true;
      this.label2.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label2.Location = new Point(35, 69);
      this.label2.Name = "label2";
      this.label2.Size = new Size(87, 20);
      this.label2.TabIndex = 1;
      this.label2.Text = "Paga Con";
      this.label3.AutoSize = true;
      this.label3.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label3.Location = new Point(61, 100);
      this.label3.Name = "label3";
      this.label3.Size = new Size(61, 20);
      this.label3.TabIndex = 2;
      this.label3.Text = "Vuelto";
      this.txtTotalPagar.BackColor = Color.FromArgb((int) byte.MaxValue, 224, 192);
      this.txtTotalPagar.BorderStyle = BorderStyle.FixedSingle;
      this.txtTotalPagar.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtTotalPagar.ForeColor = Color.Black;
      this.txtTotalPagar.Location = new Point(135, 35);
      this.txtTotalPagar.Name = "txtTotalPagar";
      this.txtTotalPagar.ReadOnly = true;
      this.txtTotalPagar.Size = new Size(121, 26);
      this.txtTotalPagar.TabIndex = 4;
      this.txtTotalPagar.TextAlign = HorizontalAlignment.Right;
      this.txtTotalPagar.KeyPress += new KeyPressEventHandler(this.txtTotalPagar_KeyPress);
      this.txtPagaCon.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtPagaCon.Location = new Point(135, 66);
      this.txtPagaCon.Name = "txtPagaCon";
      this.txtPagaCon.Size = new Size(121, 26);
      this.txtPagaCon.TabIndex = 3;
      this.txtPagaCon.TextAlign = HorizontalAlignment.Right;
      this.txtPagaCon.TextChanged += new EventHandler(this.txtPagaCon_TextChanged);
      this.txtPagaCon.KeyDown += new KeyEventHandler(this.txtPagaCon_KeyDown);
      this.txtPagaCon.KeyPress += new KeyPressEventHandler(this.txtPagaCon_KeyPress);
      this.txtVuelto.BackColor = Color.FromArgb((int) byte.MaxValue, 224, 192);
      this.txtVuelto.BorderStyle = BorderStyle.FixedSingle;
      this.txtVuelto.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtVuelto.ForeColor = Color.Black;
      this.txtVuelto.Location = new Point(135, 97);
      this.txtVuelto.Name = "txtVuelto";
      this.txtVuelto.ReadOnly = true;
      this.txtVuelto.Size = new Size(121, 26);
      this.txtVuelto.TabIndex = 5;
      this.txtVuelto.TextAlign = HorizontalAlignment.Right;
      this.label4.AutoSize = true;
      this.label4.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label4.Location = new Point(86, 160);
      this.label4.Name = "label4";
      this.label4.Size = new Size(173, 13);
      this.label4.TabIndex = 7;
      this.label4.Text = "pulse tecla ENTER para Salir";
      this.AutoScaleMode = AutoScaleMode.None;
      this.ClientSize = new Size(284, 184);
      this.Controls.Add((Control) this.label4);
      this.Controls.Add((Control) this.txtVuelto);
      this.Controls.Add((Control) this.txtPagaCon);
      this.Controls.Add((Control) this.txtTotalPagar);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmVuelto";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.FormClosing += new FormClosingEventHandler(this.frmVuelto_FormClosing);
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private void iniciaFormulario()
    {
      this.txtPagaCon.Clear();
      this.txtVuelto.Text = "0";
      this.txtPagaCon.Focus();
    }

    private void calculaVuelto()
    {
      Decimal num1 = this.txtTotalPagar.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalPagar.Text) : new Decimal(0);
      Decimal num2 = this.txtPagaCon.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPagaCon.Text) : new Decimal(0);
      Decimal num3 = new Decimal(0);
      this.txtVuelto.Text = (num2 - num1).ToString("N0");
    }

    private void soloNumeros(KeyPressEventArgs e, TextBox caja)
    {
      if ((int) e.KeyChar == 8)
      {
        e.Handled = false;
      }
      else
      {
        bool flag = false;
        int num = 0;
        for (int index = 0; index < caja.Text.Length; ++index)
        {
          if ((int) caja.Text[index] == 44)
            flag = true;
          if (flag && num++ >= 4)
          {
            e.Handled = true;
            return;
          }
        }
        if ((int) e.KeyChar >= 48 && (int) e.KeyChar <= 57)
          e.Handled = false;
        else if ((int) e.KeyChar == 44)
          e.Handled = flag;
        else
          e.Handled = true;
      }
    }

    private void txtTotalPagar_KeyPress(object sender, KeyPressEventArgs e)
    {
    }

    private void txtPagaCon_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtPagaCon);
    }

    private void txtPagaCon_TextChanged(object sender, EventArgs e)
    {
      if (this.modulo.Equals("boleta_fiscal"))
      {
        if (this.txtPagaCon.Text.Trim().Length < 9)
        {
          this.calculaVuelto();
        }
        else
        {
          int num = (int) MessageBox.Show("El Valor Ingresado es demasiado Grande", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          this.txtPagaCon.Focus();
        }
      }
      else
        this.calculaVuelto();
    }

    private void txtPagaCon_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this.validaVuelto();
    }

    private void validaVuelto()
    {
      Decimal num1 = this.txtTotalPagar.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalPagar.Text) : new Decimal(0);
      Decimal num2 = this.txtPagaCon.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPagaCon.Text) : new Decimal(0);
      if (num2 > new Decimal(0) && num2 < num1)
      {
        int num3 = (int) MessageBox.Show("El Monto debe ser igual o superior al Total", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.txtPagaCon.Focus();
        this.puedeSalir = false;
      }
      else
      {
        string str = this.txtPagaCon.Text.Trim().Length > 0 ? this.txtPagaCon.Text : "0";
        if (this.modulo.Equals("boleta"))
          this.frmBol.muestraVuelto(Convert.ToDecimal(str).ToString("N0"), this.txtVuelto.Text);
        if (this.modulo.Equals("boleta_fiscal"))
          this.frmBolFis.muestraVuelto(Convert.ToDecimal(str).ToString("N0"), this.txtVuelto.Text);
        this.puedeSalir = true;
        this.Close();
      }
    }

    private void frmVuelto_FormClosing(object sender, FormClosingEventArgs e)
    {
      Decimal num1 = this.txtPagaCon.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPagaCon.Text) : new Decimal(0);
      Decimal num2 = this.txtTotalPagar.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalPagar.Text) : new Decimal(0);
      if (num1 == new Decimal(0))
      {
        this.txtPagaCon.Text = this.txtTotalPagar.Text;
        this.calculaVuelto();
        string str = this.txtPagaCon.Text.Trim().Length > 0 ? this.txtPagaCon.Text : "0";
        if (this.modulo.Equals("boleta"))
          this.frmBol.muestraVuelto(Convert.ToDecimal(str).ToString("N0"), this.txtVuelto.Text);
        if (!this.modulo.Equals("boleta_fiscal"))
          return;
        this.frmBolFis.muestraVuelto(Convert.ToDecimal(str).ToString("N0"), this.txtVuelto.Text);
      }
      else if (num1 < num2)
      {
        int num3 = (int) MessageBox.Show("El Monto a Pagar debe ser SUPERIOR O IGUAL al Total", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.txtPagaCon.Focus();
        e.Cancel = true;
      }
      else
      {
        string str = this.txtPagaCon.Text.Trim().Length > 0 ? this.txtPagaCon.Text : "0";
        if (this.modulo.Equals("boleta"))
          this.frmBol.muestraVuelto(Convert.ToDecimal(str).ToString("N0"), this.txtVuelto.Text);
        if (this.modulo.Equals("boleta_fiscal"))
          this.frmBolFis.muestraVuelto(Convert.ToDecimal(str).ToString("N0"), this.txtVuelto.Text);
      }
    }
  }
}
