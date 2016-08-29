 
// Type: Aptusoft.frmMuestraCredito
 
 
// version 1.8.0

using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Aptusoft
{
  public class frmMuestraCredito : Form
  {
    private int codigoCliente = 0;
    private IContainer components = (IContainer) null;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private Label label6;
    private TextBox txtCreditoAprobado;
    private TextBox txtFacturas;
    private TextBox txtFacturasExentas;
    private TextBox txtBoletas;
    private TextBox txtGuias;
    private TextBox txtCreditoDisponible;
    private Button button1;
    private TextBox txtTotal;
    private Label label7;
    private TextBox txtNotaCredito;
    private Label label8;
    private Button btnDetalle;
    private GroupBox groupBox1;
    private TextBox txtENotaCredito;
    private Label label13;
    private Label label12;
    private TextBox txtEBoletas;
    private Label label11;
    private TextBox txtEGuias;
    private Label label10;
    private TextBox txtEfacturaExenta;
    private Label label9;
    private TextBox txtEfactura;

    public frmMuestraCredito(int codCli)
    {
      this.InitializeComponent();
      this.codigoCliente = codCli;
      this.muestraCredito();
    }

    public void muestraCredito()
    {
      try
      {
        List<CreditoVO> list = new Credito().verificaCredito(this.codigoCliente);
        Decimal num1 = new Decimal(0);
        Decimal num2;
        foreach (CreditoVO creditoVo in list)
        {
          switch (creditoVo.Codigo)
          {
            case 40:
              TextBox textBox1 = this.txtEBoletas;
              num2 = creditoVo.Total;
              string str1 = num2.ToString("C0");
              textBox1.Text = str1;
              num1 += creditoVo.Total;
              break;
            case 50:
              TextBox textBox2 = this.txtEGuias;
              num2 = creditoVo.Total;
              string str2 = num2.ToString("C0");
              textBox2.Text = str2;
              num1 += creditoVo.Total;
              break;
            case 60:
              TextBox textBox3 = this.txtENotaCredito;
              num2 = creditoVo.Total * new Decimal(-1);
              string str3 = num2.ToString("C0");
              textBox3.Text = str3;
              num1 -= creditoVo.Total;
              break;
            case 1:
              TextBox textBox4 = this.txtCreditoAprobado;
              num2 = creditoVo.Total;
              string str4 = num2.ToString("C0");
              textBox4.Text = str4;
              break;
            case 2:
              TextBox textBox5 = this.txtFacturas;
              num2 = creditoVo.Total;
              string str5 = num2.ToString("C0");
              textBox5.Text = str5;
              num1 += creditoVo.Total;
              break;
            case 3:
              TextBox textBox6 = this.txtFacturasExentas;
              num2 = creditoVo.Total;
              string str6 = num2.ToString("C0");
              textBox6.Text = str6;
              num1 += creditoVo.Total;
              break;
            case 4:
              TextBox textBox7 = this.txtBoletas;
              num2 = creditoVo.Total;
              string str7 = num2.ToString("C0");
              textBox7.Text = str7;
              num1 += creditoVo.Total;
              break;
            case 5:
              TextBox textBox8 = this.txtGuias;
              num2 = creditoVo.Total;
              string str8 = num2.ToString("C0");
              textBox8.Text = str8;
              num1 += creditoVo.Total;
              break;
            case 6:
              TextBox textBox9 = this.txtNotaCredito;
              num2 = creditoVo.Total * new Decimal(-1);
              string str9 = num2.ToString("C0");
              textBox9.Text = str9;
              num1 -= creditoVo.Total;
              break;
            case 7:
              TextBox textBox10 = this.txtCreditoDisponible;
              num2 = creditoVo.Total;
              string str10 = num2.ToString("C0");
              textBox10.Text = str10;
              break;
            case 20:
              TextBox textBox11 = this.txtEfactura;
              num2 = creditoVo.Total;
              string str11 = num2.ToString("C0");
              textBox11.Text = str11;
              num1 += creditoVo.Total;
              break;
            case 30:
              TextBox textBox12 = this.txtEfacturaExenta;
              num2 = creditoVo.Total;
              string str12 = num2.ToString("C0");
              textBox12.Text = str12;
              num1 += creditoVo.Total;
              break;
          }
        }
        this.txtTotal.Text = num1.ToString("C0");
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error: " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void btnDetalle_Click(object sender, EventArgs e)
    {
      this.muestraInforme();
    }

    private void muestraInforme()
    {
      DataTable dataTable1 = new DataTable();
      string filtro = "idCliente='" + (object) this.codigoCliente + "'";
      string str = "Venta010.rpt";
      DataTable dataTable2 = new VentaGeneral().boletaFacturaNotaCreditoInforme(filtro);
      ReportDocument rpt = new ReportDocument();
      rpt.Load("C:\\AptuSoft\\reportes\\" + str);
      rpt.SetDataSource(dataTable2);
      new frmVisualizadorReportes(rpt).Show();
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
      this.label4 = new Label();
      this.label5 = new Label();
      this.label6 = new Label();
      this.txtCreditoAprobado = new TextBox();
      this.txtFacturas = new TextBox();
      this.txtFacturasExentas = new TextBox();
      this.txtBoletas = new TextBox();
      this.txtGuias = new TextBox();
      this.txtCreditoDisponible = new TextBox();
      this.button1 = new Button();
      this.txtTotal = new TextBox();
      this.label7 = new Label();
      this.txtNotaCredito = new TextBox();
      this.label8 = new Label();
      this.btnDetalle = new Button();
      this.groupBox1 = new GroupBox();
      this.label9 = new Label();
      this.txtEfactura = new TextBox();
      this.label10 = new Label();
      this.txtEfacturaExenta = new TextBox();
      this.label11 = new Label();
      this.txtEGuias = new TextBox();
      this.label12 = new Label();
      this.txtEBoletas = new TextBox();
      this.txtENotaCredito = new TextBox();
      this.label13 = new Label();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      this.label1.AutoSize = true;
      this.label1.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label1.Location = new Point(12, 352);
      this.label1.Name = "label1";
      this.label1.Size = new Size(118, 15);
      this.label1.TabIndex = 0;
      this.label1.Text = "Crédito Aprobado";
      this.label2.AutoSize = true;
      this.label2.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label2.Location = new Point(6, 16);
      this.label2.Name = "label2";
      this.label2.Size = new Size(119, 15);
      this.label2.TabIndex = 1;
      this.label2.Text = "Facturas Pendientes";
      this.label3.AutoSize = true;
      this.label3.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label3.Location = new Point(6, 40);
      this.label3.Name = "label3";
      this.label3.Size = new Size(166, 15);
      this.label3.TabIndex = 2;
      this.label3.Text = "Facturas Exentas Pendientes";
      this.label4.AutoSize = true;
      this.label4.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label4.Location = new Point(6, 64);
      this.label4.Name = "label4";
      this.label4.Size = new Size(113, 15);
      this.label4.TabIndex = 3;
      this.label4.Text = "Boletas Pendientes";
      this.label5.AutoSize = true;
      this.label5.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label5.Location = new Point(6, 91);
      this.label5.Name = "label5";
      this.label5.Size = new Size(108, 15);
      this.label5.TabIndex = 4;
      this.label5.Text = "Guías Sin Facturar";
      this.label6.AutoSize = true;
      this.label6.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label6.Location = new Point(12, 383);
      this.label6.Name = "label6";
      this.label6.Size = new Size(130, 15);
      this.label6.TabIndex = 5;
      this.label6.Text = "Crédito Disponible ";
      this.txtCreditoAprobado.BackColor = Color.White;
      this.txtCreditoAprobado.BorderStyle = BorderStyle.FixedSingle;
      this.txtCreditoAprobado.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtCreditoAprobado.ForeColor = Color.Black;
      this.txtCreditoAprobado.Location = new Point(220, 349);
      this.txtCreditoAprobado.Name = "txtCreditoAprobado";
      this.txtCreditoAprobado.ReadOnly = true;
      this.txtCreditoAprobado.Size = new Size(100, 21);
      this.txtCreditoAprobado.TabIndex = 9;
      this.txtCreditoAprobado.TextAlign = HorizontalAlignment.Right;
      this.txtFacturas.BackColor = Color.White;
      this.txtFacturas.BorderStyle = BorderStyle.FixedSingle;
      this.txtFacturas.ForeColor = Color.Black;
      this.txtFacturas.Location = new Point(214, 16);
      this.txtFacturas.Name = "txtFacturas";
      this.txtFacturas.ReadOnly = true;
      this.txtFacturas.Size = new Size(100, 20);
      this.txtFacturas.TabIndex = 3;
      this.txtFacturas.TextAlign = HorizontalAlignment.Right;
      this.txtFacturasExentas.BackColor = Color.White;
      this.txtFacturasExentas.BorderStyle = BorderStyle.FixedSingle;
      this.txtFacturasExentas.ForeColor = Color.Black;
      this.txtFacturasExentas.Location = new Point(214, 40);
      this.txtFacturasExentas.Name = "txtFacturasExentas";
      this.txtFacturasExentas.ReadOnly = true;
      this.txtFacturasExentas.Size = new Size(100, 20);
      this.txtFacturasExentas.TabIndex = 4;
      this.txtFacturasExentas.TextAlign = HorizontalAlignment.Right;
      this.txtBoletas.BackColor = Color.White;
      this.txtBoletas.BorderStyle = BorderStyle.FixedSingle;
      this.txtBoletas.ForeColor = Color.Black;
      this.txtBoletas.Location = new Point(214, 64);
      this.txtBoletas.Name = "txtBoletas";
      this.txtBoletas.ReadOnly = true;
      this.txtBoletas.Size = new Size(100, 20);
      this.txtBoletas.TabIndex = 5;
      this.txtBoletas.TextAlign = HorizontalAlignment.Right;
      this.txtGuias.BackColor = Color.White;
      this.txtGuias.BorderStyle = BorderStyle.FixedSingle;
      this.txtGuias.ForeColor = Color.Black;
      this.txtGuias.Location = new Point(214, 88);
      this.txtGuias.Name = "txtGuias";
      this.txtGuias.ReadOnly = true;
      this.txtGuias.Size = new Size(100, 20);
      this.txtGuias.TabIndex = 6;
      this.txtGuias.TextAlign = HorizontalAlignment.Right;
      this.txtCreditoDisponible.BackColor = Color.White;
      this.txtCreditoDisponible.BorderStyle = BorderStyle.FixedSingle;
      this.txtCreditoDisponible.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtCreditoDisponible.ForeColor = Color.Red;
      this.txtCreditoDisponible.Location = new Point(220, 383);
      this.txtCreditoDisponible.Name = "txtCreditoDisponible";
      this.txtCreditoDisponible.ReadOnly = true;
      this.txtCreditoDisponible.Size = new Size(100, 21);
      this.txtCreditoDisponible.TabIndex = 10;
      this.txtCreditoDisponible.TextAlign = HorizontalAlignment.Right;
      this.button1.Location = new Point(220, 410);
      this.button1.Name = "button1";
      this.button1.Size = new Size(100, 23);
      this.button1.TabIndex = 2;
      this.button1.Text = "Salir";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.txtTotal.BackColor = Color.White;
      this.txtTotal.BorderStyle = BorderStyle.FixedSingle;
      this.txtTotal.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtTotal.ForeColor = Color.Black;
      this.txtTotal.Location = new Point(214, 283);
      this.txtTotal.Name = "txtTotal";
      this.txtTotal.ReadOnly = true;
      this.txtTotal.Size = new Size(100, 21);
      this.txtTotal.TabIndex = 8;
      this.txtTotal.TextAlign = HorizontalAlignment.Right;
      this.label7.AutoSize = true;
      this.label7.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label7.Location = new Point(6, 283);
      this.label7.Name = "label7";
      this.label7.Size = new Size(108, 15);
      this.label7.TabIndex = 14;
      this.label7.Text = "Total Pendiente";
      this.txtNotaCredito.BackColor = Color.White;
      this.txtNotaCredito.BorderStyle = BorderStyle.FixedSingle;
      this.txtNotaCredito.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtNotaCredito.ForeColor = Color.Black;
      this.txtNotaCredito.Location = new Point(214, 249);
      this.txtNotaCredito.Name = "txtNotaCredito";
      this.txtNotaCredito.ReadOnly = true;
      this.txtNotaCredito.Size = new Size(100, 20);
      this.txtNotaCredito.TabIndex = 7;
      this.txtNotaCredito.TextAlign = HorizontalAlignment.Right;
      this.label8.AutoSize = true;
      this.label8.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label8.Location = new Point(6, 249);
      this.label8.Name = "label8";
      this.label8.Size = new Size(152, 15);
      this.label8.TabIndex = 15;
      this.label8.Text = "Nota de Crédito disponible";
      this.btnDetalle.Location = new Point(15, 410);
      this.btnDetalle.Name = "btnDetalle";
      this.btnDetalle.Size = new Size(116, 23);
      this.btnDetalle.TabIndex = 1;
      this.btnDetalle.Text = "Ver Detalles";
      this.btnDetalle.UseVisualStyleBackColor = true;
      this.btnDetalle.Click += new EventHandler(this.btnDetalle_Click);
      this.groupBox1.Controls.Add((Control) this.txtENotaCredito);
      this.groupBox1.Controls.Add((Control) this.label13);
      this.groupBox1.Controls.Add((Control) this.label12);
      this.groupBox1.Controls.Add((Control) this.txtEBoletas);
      this.groupBox1.Controls.Add((Control) this.label11);
      this.groupBox1.Controls.Add((Control) this.txtEGuias);
      this.groupBox1.Controls.Add((Control) this.label10);
      this.groupBox1.Controls.Add((Control) this.txtEfacturaExenta);
      this.groupBox1.Controls.Add((Control) this.label9);
      this.groupBox1.Controls.Add((Control) this.txtEfactura);
      this.groupBox1.Controls.Add((Control) this.label2);
      this.groupBox1.Controls.Add((Control) this.label3);
      this.groupBox1.Controls.Add((Control) this.txtNotaCredito);
      this.groupBox1.Controls.Add((Control) this.label4);
      this.groupBox1.Controls.Add((Control) this.label8);
      this.groupBox1.Controls.Add((Control) this.label5);
      this.groupBox1.Controls.Add((Control) this.label7);
      this.groupBox1.Controls.Add((Control) this.txtFacturas);
      this.groupBox1.Controls.Add((Control) this.txtTotal);
      this.groupBox1.Controls.Add((Control) this.txtFacturasExentas);
      this.groupBox1.Controls.Add((Control) this.txtBoletas);
      this.groupBox1.Controls.Add((Control) this.txtGuias);
      this.groupBox1.Location = new Point(5, 2);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(330, 341);
      this.groupBox1.TabIndex = 11;
      this.groupBox1.TabStop = false;
      this.label9.AutoSize = true;
      this.label9.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label9.Location = new Point(6, 115);
      this.label9.Name = "label9";
      this.label9.Size = new Size(131, 15);
      this.label9.TabIndex = 16;
      this.label9.Text = "E-Facturas Pendientes";
      this.txtEfactura.BackColor = Color.White;
      this.txtEfactura.BorderStyle = BorderStyle.FixedSingle;
      this.txtEfactura.ForeColor = Color.Black;
      this.txtEfactura.Location = new Point(214, 112);
      this.txtEfactura.Name = "txtEfactura";
      this.txtEfactura.ReadOnly = true;
      this.txtEfactura.Size = new Size(100, 20);
      this.txtEfactura.TabIndex = 17;
      this.txtEfactura.TextAlign = HorizontalAlignment.Right;
      this.label10.AutoSize = true;
      this.label10.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label10.Location = new Point(6, 139);
      this.label10.Name = "label10";
      this.label10.Size = new Size(181, 15);
      this.label10.TabIndex = 18;
      this.label10.Text = "E- Facturas Exentas Pendientes";
      this.txtEfacturaExenta.BackColor = Color.White;
      this.txtEfacturaExenta.BorderStyle = BorderStyle.FixedSingle;
      this.txtEfacturaExenta.ForeColor = Color.Black;
      this.txtEfacturaExenta.Location = new Point(215, 136);
      this.txtEfacturaExenta.Name = "txtEfacturaExenta";
      this.txtEfacturaExenta.ReadOnly = true;
      this.txtEfacturaExenta.Size = new Size(100, 20);
      this.txtEfacturaExenta.TabIndex = 19;
      this.txtEfacturaExenta.TextAlign = HorizontalAlignment.Right;
      this.label11.AutoSize = true;
      this.label11.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label11.Location = new Point(6, 187);
      this.label11.Name = "label11";
      this.label11.Size = new Size(120, 15);
      this.label11.TabIndex = 20;
      this.label11.Text = "E-Guias Sin Facturar";
      this.txtEGuias.BackColor = Color.White;
      this.txtEGuias.BorderStyle = BorderStyle.FixedSingle;
      this.txtEGuias.ForeColor = Color.Black;
      this.txtEGuias.Location = new Point(215, 184);
      this.txtEGuias.Name = "txtEGuias";
      this.txtEGuias.ReadOnly = true;
      this.txtEGuias.Size = new Size(100, 20);
      this.txtEGuias.TabIndex = 21;
      this.txtEGuias.TextAlign = HorizontalAlignment.Right;
      this.label12.AutoSize = true;
      this.label12.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label12.Location = new Point(6, 163);
      this.label12.Name = "label12";
      this.label12.Size = new Size(125, 15);
      this.label12.TabIndex = 22;
      this.label12.Text = "E-Boletas Pendientes";
      this.txtEBoletas.BackColor = Color.White;
      this.txtEBoletas.BorderStyle = BorderStyle.FixedSingle;
      this.txtEBoletas.ForeColor = Color.Black;
      this.txtEBoletas.Location = new Point(214, 160);
      this.txtEBoletas.Name = "txtEBoletas";
      this.txtEBoletas.ReadOnly = true;
      this.txtEBoletas.Size = new Size(100, 20);
      this.txtEBoletas.TabIndex = 23;
      this.txtEBoletas.TextAlign = HorizontalAlignment.Right;
      this.txtENotaCredito.BackColor = Color.White;
      this.txtENotaCredito.BorderStyle = BorderStyle.FixedSingle;
      this.txtENotaCredito.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtENotaCredito.ForeColor = Color.Black;
      this.txtENotaCredito.Location = new Point(215, 226);
      this.txtENotaCredito.Name = "txtENotaCredito";
      this.txtENotaCredito.ReadOnly = true;
      this.txtENotaCredito.Size = new Size(100, 20);
      this.txtENotaCredito.TabIndex = 24;
      this.txtENotaCredito.TextAlign = HorizontalAlignment.Right;
      this.label13.AutoSize = true;
      this.label13.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label13.Location = new Point(6, 229);
      this.label13.Name = "label13";
      this.label13.Size = new Size(164, 15);
      this.label13.TabIndex = 25;
      this.label13.Text = "E-Nota de Crédito disponible";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
//      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(223, 233, 245);
      this.ClientSize = new Size(344, 448);
      this.Controls.Add((Control) this.groupBox1);
      this.Controls.Add((Control) this.btnDetalle);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.txtCreditoDisponible);
      this.Controls.Add((Control) this.txtCreditoAprobado);
      this.Controls.Add((Control) this.label6);
      this.Controls.Add((Control) this.label1);
//      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Name = "frmMuestraCredito";
      this.Text = "Datos Crédito";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
