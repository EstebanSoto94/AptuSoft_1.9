 
// Type: Aptusoft.frmAlertaSoporte
 
 
// version 1.8.0

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Aptusoft
{
  public class frmAlertaSoporte : Form
  {
    private IContainer components = (IContainer) null;
    private Label label1;
    private TextBox txtCliente;
    private Label label2;
    private Label label3;
    private TextBox txtHora;
    private Label label4;
    private TextBox txtFecha;
    private Label label5;
    private TextBox txtContacto;
    private Label label6;
    private TextBox txtFonoContacto;
    private TextBox txtEmail;
    private Label label7;
    private Panel panel1;
    private Label label8;
    private TextBox txtRequerimiento;
    private Label label9;

    public frmAlertaSoporte(OrdenAtencionVO oaVO)
    {
      this.InitializeComponent();
      this.buscaOrdeAtencion(oaVO);
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
      this.txtCliente = new TextBox();
      this.label2 = new Label();
      this.label3 = new Label();
      this.txtHora = new TextBox();
      this.label4 = new Label();
      this.txtFecha = new TextBox();
      this.label5 = new Label();
      this.txtContacto = new TextBox();
      this.label6 = new Label();
      this.txtFonoContacto = new TextBox();
      this.txtEmail = new TextBox();
      this.label7 = new Label();
      this.panel1 = new Panel();
      this.label8 = new Label();
      this.txtRequerimiento = new TextBox();
      this.label9 = new Label();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      this.label1.BackColor = Color.SteelBlue;
      this.label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label1.ForeColor = Color.White;
      this.label1.Location = new Point(3, 14);
      this.label1.Name = "label1";
      this.label1.Size = new Size(74, 22);
      this.label1.TabIndex = 0;
      this.label1.Text = "Cliente";
      this.txtCliente.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtCliente.Location = new Point(77, 14);
      this.txtCliente.Name = "txtCliente";
      this.txtCliente.Size = new Size(340, 21);
      this.txtCliente.TabIndex = 1;
      this.label2.BackColor = Color.SteelBlue;
      this.label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label2.ForeColor = Color.White;
      this.label2.Location = new Point(175, 43);
      this.label2.Name = "label2";
      this.label2.Size = new Size(50, 22);
      this.label2.TabIndex = 2;
      this.label2.Text = "a las :";
      this.label3.BackColor = Color.SteelBlue;
      this.label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label3.ForeColor = Color.White;
      this.label3.Location = new Point(267, 43);
      this.label3.Name = "label3";
      this.label3.Size = new Size(51, 22);
      this.label3.TabIndex = 3;
      this.label3.Text = "Hrs.";
      this.txtHora.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtHora.Location = new Point(226, 43);
      this.txtHora.Name = "txtHora";
      this.txtHora.Size = new Size(39, 21);
      this.txtHora.TabIndex = 4;
      this.label4.BackColor = Color.SteelBlue;
      this.label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label4.ForeColor = Color.White;
      this.label4.Location = new Point(3, 43);
      this.label4.Name = "label4";
      this.label4.Size = new Size(74, 22);
      this.label4.TabIndex = 5;
      this.label4.Text = "el dia :";
      this.label4.Click += new EventHandler(this.label4_Click);
      this.txtFecha.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtFecha.Location = new Point(77, 43);
      this.txtFecha.Name = "txtFecha";
      this.txtFecha.Size = new Size(90, 21);
      this.txtFecha.TabIndex = 6;
      this.label5.BackColor = Color.SteelBlue;
      this.label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label5.ForeColor = Color.White;
      this.label5.Location = new Point(3, 73);
      this.label5.Name = "label5";
      this.label5.Size = new Size(74, 22);
      this.label5.TabIndex = 7;
      this.label5.Text = "Contacto:";
      this.txtContacto.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtContacto.Location = new Point(77, 72);
      this.txtContacto.Name = "txtContacto";
      this.txtContacto.Size = new Size(215, 21);
      this.txtContacto.TabIndex = 8;
      this.label6.BackColor = Color.SteelBlue;
      this.label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label6.ForeColor = Color.White;
      this.label6.Location = new Point(3, 104);
      this.label6.Name = "label6";
      this.label6.Size = new Size(74, 22);
      this.label6.TabIndex = 9;
      this.label6.Text = "Telefono:";
      this.txtFonoContacto.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtFonoContacto.Location = new Point(77, 103);
      this.txtFonoContacto.Name = "txtFonoContacto";
      this.txtFonoContacto.Size = new Size(141, 21);
      this.txtFonoContacto.TabIndex = 10;
      this.txtEmail.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtEmail.Location = new Point(77, 132);
      this.txtEmail.Name = "txtEmail";
      this.txtEmail.Size = new Size(141, 21);
      this.txtEmail.TabIndex = 12;
      this.label7.BackColor = Color.SteelBlue;
      this.label7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label7.ForeColor = Color.White;
      this.label7.Location = new Point(3, 133);
      this.label7.Name = "label7";
      this.label7.Size = new Size(74, 22);
      this.label7.TabIndex = 11;
      this.label7.Text = "Email:";
      this.panel1.BorderStyle = BorderStyle.Fixed3D;
      this.panel1.Controls.Add((Control) this.label9);
      this.panel1.Controls.Add((Control) this.txtRequerimiento);
      this.panel1.Controls.Add((Control) this.txtEmail);
      this.panel1.Controls.Add((Control) this.txtCliente);
      this.panel1.Controls.Add((Control) this.txtFonoContacto);
      this.panel1.Controls.Add((Control) this.txtHora);
      this.panel1.Controls.Add((Control) this.txtContacto);
      this.panel1.Controls.Add((Control) this.txtFecha);
      this.panel1.Controls.Add((Control) this.label1);
      this.panel1.Controls.Add((Control) this.label7);
      this.panel1.Controls.Add((Control) this.label2);
      this.panel1.Controls.Add((Control) this.label3);
      this.panel1.Controls.Add((Control) this.label6);
      this.panel1.Controls.Add((Control) this.label4);
      this.panel1.Controls.Add((Control) this.label5);
      this.panel1.Location = new Point(9, 55);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(428, 285);
      this.panel1.TabIndex = 13;
      this.label8.AutoSize = true;
      this.label8.Font = new Font("Microsoft Sans Serif", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label8.ForeColor = Color.Red;
      this.label8.Location = new Point(12, 13);
      this.label8.Name = "label8";
      this.label8.Size = new Size(286, 29);
      this.label8.TabIndex = 14;
      this.label8.Text = "ALERTA DE SOPORTE";
      this.txtRequerimiento.Location = new Point(5, 196);
      this.txtRequerimiento.Multiline = true;
      this.txtRequerimiento.Name = "txtRequerimiento";
      this.txtRequerimiento.Size = new Size(411, 77);
      this.txtRequerimiento.TabIndex = 13;
      this.label9.BackColor = Color.SteelBlue;
      this.label9.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label9.ForeColor = Color.White;
      this.label9.Location = new Point(3, 176);
      this.label9.Name = "label9";
      this.label9.Size = new Size(414, 22);
      this.label9.TabIndex = 14;
      this.label9.Text = "Requerimiento";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
//      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(223, 233, 245);
      this.ClientSize = new Size(449, 352);
      this.Controls.Add((Control) this.label8);
      this.Controls.Add((Control) this.panel1);
//      this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
      this.Name = "frmAlertaSoporte";
      this.Text = "Alerta Soporte";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private void buscaOrdeAtencion(OrdenAtencionVO oaVO)
    {
      this.txtCliente.Text = oaVO.RazonSocial;
      this.txtContacto.Text = oaVO.Contacto;
      this.txtEmail.Text = oaVO.Email;
      this.txtFonoContacto.Text = oaVO.Fono;
      this.txtRequerimiento.Text = oaVO.Requerimiento;
      DateTime fechaAtencion = oaVO.FechaAtencion;
      TextBox textBox = this.txtHora;
      int num = fechaAtencion.Hour;
      string str1 = num.ToString("N0");
      string str2 = ":";
      num = fechaAtencion.Minute;
      string str3 = num.ToString("N0");
      string str4 = str1 + str2 + str3;
      textBox.Text = str4;
      this.txtFecha.Text = fechaAtencion.ToShortDateString();
    }

    private void label4_Click(object sender, EventArgs e)
    {
    }
  }
}
