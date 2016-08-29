 
// Type: Aptusoft.frmAtencionPreventa
 
 
// version 1.8.0

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Aptusoft
{
  public class frmAtencionPreventa : Form
  {
    private int codigoCliente = 0;
    private int idOrden = 0;
    private AtencionPreVenta ap = new AtencionPreVenta();
    private IContainer components = (IContainer) null;
    private Label lblFecha;
    private Label lblNumero;
    private GroupBox groupBox1;
    private Label label10;
    private TextBox txtFono;
    private Label label9;
    private TextBox txtEmail;
    private Button btnSalir;
    private Button btnGuardar;
    private TextBox txtContacto;
    private Label label7;
    private Label label6;
    private TextBox txtNombre;
    private TextBox txtDigito;
    private TextBox txtRut;
    private Label label5;
    private ComboBox cmbEstado;
    private Label label4;
    private Label label3;
    private ComboBox cmbVendedor;
    private Label label1;
    private TextBox txtObservaciones;
    private TextBox txtFono3;
    private TextBox txtEmail3;
    private TextBox txtFono2;
    private TextBox txtEmail2;
    private Label label11;
    private NumericUpDown nudMinuto;
    private NumericUpDown nudHora;
    private DateTimePicker dtpFechaAtencion;

    public frmAtencionPreventa(int idO)
    {
      this.InitializeComponent();
      this.idOrden = idO;
      this.iniciaFormulario(this.buscaOrdenAtencion(this.idOrden));
    }

    public frmAtencionPreventa(OrdenAtencionVO oa, int idO)
    {
      this.InitializeComponent();
      this.idOrden = idO;
      this.iniciaFormulario(oa);
    }

    private void cargaVendedores()
    {
      this.cmbVendedor.DataSource = (object) new Vendedor().listaVendedoresVenta();
      this.cmbVendedor.ValueMember = "idVendedor";
      this.cmbVendedor.DisplayMember = "nombre";
      this.cmbVendedor.SelectedValue = (object) 0;
    }

    private void cargaNumero()
    {
      this.lblNumero.Text = "Atencion N° : " + this.ap.numeroAtencion();
    }

    private void cargaEstado()
    {
      this.cmbEstado.DataSource = (object) new CargaMaestros().listaEstadoOT();
      this.cmbEstado.ValueMember = "IdBodega";
      this.cmbEstado.DisplayMember = "NombreBodega";
      this.cmbEstado.SelectedValue = (object) 1;
    }

    private void iniciaFormulario(OrdenAtencionVO cl)
    {
      this.cargaVendedores();
      this.cargaNumero();
      this.cargaEstado();
      this.lblFecha.Text = "Fecha: " + DateTime.Now.ToShortDateString();
      this.codigoCliente = cl.IdCliente;
      this.txtRut.Text = cl.Rut;
      this.txtRut.Enabled = false;
      this.txtDigito.Text = cl.Digito;
      this.txtDigito.Enabled = false;
      this.txtNombre.Text = cl.RazonSocial;
      this.txtNombre.Enabled = false;
      this.txtContacto.Text = cl.Contacto;
      this.txtEmail.Text = cl.Email;
      this.txtEmail.Enabled = false;
      this.txtFono.Text = cl.Fono;
      this.txtFono.Enabled = false;
      this.txtEmail2.Text = cl.Email2;
      this.txtFono2.Text = cl.Fono2;
      this.txtEmail3.Text = cl.Email3;
      this.txtFono3.Text = cl.Fono3;
      this.txtObservaciones.Text = cl.Requerimiento;
      this.cmbVendedor.Text = cl.Tecnico;
      if (cl.Estado != null)
        this.cmbEstado.Text = cl.Estado;
      DateTime fechaAtencion = cl.FechaAtencion;
      int num = fechaAtencion.Hour;
      if (num > 12)
        num = 12;
      this.nudHora.Value = Convert.ToDecimal(num.ToString("N0"));
      this.nudMinuto.Value = Convert.ToDecimal(fechaAtencion.Minute.ToString("N0"));
      this.dtpFechaAtencion.Value = fechaAtencion;
      this.txtObservaciones.Focus();
    }

    private OrdenAtencionVO buscaOrdenAtencion(int id)
    {
      return new AtencionPreVenta().buscaOrdenPreventa(id);
    }

    private OrdenAtencionVO armaOrden()
    {
      OrdenAtencionVO ordenAtencionVo = new OrdenAtencionVO();
      ordenAtencionVo.IdOrdenAtencion = this.idOrden;
      ordenAtencionVo.IdCliente = this.codigoCliente;
      ordenAtencionVo.Rut = this.txtRut.Text;
      ordenAtencionVo.Digito = this.txtDigito.Text;
      ordenAtencionVo.RazonSocial = this.txtNombre.Text;
      ordenAtencionVo.Contacto = this.txtContacto.Text;
      ordenAtencionVo.Email = this.txtEmail.Text;
      ordenAtencionVo.Fono = this.txtFono.Text;
      ordenAtencionVo.Email2 = this.txtEmail2.Text;
      ordenAtencionVo.Fono2 = this.txtFono2.Text;
      ordenAtencionVo.Email3 = this.txtEmail3.Text;
      ordenAtencionVo.Fono3 = this.txtFono3.Text;
      ordenAtencionVo.Tecnico = this.cmbVendedor.Text;
      ordenAtencionVo.IdTecnico = Convert.ToInt32(this.cmbVendedor.SelectedValue.ToString());
      ordenAtencionVo.Estado = this.cmbEstado.Text;
      ordenAtencionVo.Requerimiento = this.txtObservaciones.Text;
      DateTime dateTime= DateTime.Now;
      // ISSUE: explicit reference operation
      // ISSUE: variable of a reference type
      DateTime local = @dateTime;
      DateTime now = this.dtpFechaAtencion.Value;
      int year = now.Year;
      now = this.dtpFechaAtencion.Value;
      int month = now.Month;
      now = this.dtpFechaAtencion.Value;
      int day = now.Day;
      int hour = Convert.ToInt32(this.nudHora.Value);
      int minute = Convert.ToInt32(this.nudMinuto.Value);
      now = DateTime.Now;
      int seconds = now.TimeOfDay.Seconds;
      // ISSUE: explicit reference operation
      local = new DateTime(year, month, day, hour, minute, seconds);
      ordenAtencionVo.FechaAtencion = dateTime;
      return ordenAtencionVo;
    }

    private void guardaModifica()
    {
      if (this.txtObservaciones.Text.Length > 0)
      {
        if (this.idOrden == 0)
        {
          this.ap = new AtencionPreVenta();
          this.ap.agregaOrden(this.armaOrden());
          int num = (int) MessageBox.Show("Atencion Ingresada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          this.Close();
        }
        else
        {
          this.ap = new AtencionPreVenta();
          this.ap.modificaOrden(this.armaOrden());
          int num = (int) MessageBox.Show("Atencion Modificada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          this.Close();
        }
      }
      else
      {
        int num1 = (int) MessageBox.Show("Debe Ingresar una Observacion", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
      try
      {
        this.guardaModifica();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al Conectar con Servidor, intentelo nuevamente " + ex.Message, "Error de Conexion", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        Conexion.reconexion();
      }
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.lblFecha = new Label();
      this.lblNumero = new Label();
      this.groupBox1 = new GroupBox();
      this.txtFono3 = new TextBox();
      this.txtEmail3 = new TextBox();
      this.txtFono2 = new TextBox();
      this.txtEmail2 = new TextBox();
      this.label10 = new Label();
      this.txtFono = new TextBox();
      this.label9 = new Label();
      this.txtEmail = new TextBox();
      this.btnSalir = new Button();
      this.btnGuardar = new Button();
      this.txtContacto = new TextBox();
      this.label7 = new Label();
      this.label6 = new Label();
      this.txtNombre = new TextBox();
      this.txtDigito = new TextBox();
      this.txtRut = new TextBox();
      this.label5 = new Label();
      this.cmbEstado = new ComboBox();
      this.label4 = new Label();
      this.label3 = new Label();
      this.cmbVendedor = new ComboBox();
      this.label1 = new Label();
      this.txtObservaciones = new TextBox();
      this.label11 = new Label();
      this.nudMinuto = new NumericUpDown();
      this.nudHora = new NumericUpDown();
      this.dtpFechaAtencion = new DateTimePicker();
      this.groupBox1.SuspendLayout();
      this.nudMinuto.BeginInit();
      this.nudHora.BeginInit();
      this.SuspendLayout();
      this.lblFecha.AutoSize = true;
      this.lblFecha.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblFecha.ForeColor = Color.MidnightBlue;
      this.lblFecha.Location = new Point(28, 6);
      this.lblFecha.Name = "lblFecha";
      this.lblFecha.Size = new Size(42, 15);
      this.lblFecha.TabIndex = 25;
      this.lblFecha.Text = "fecha";
      this.lblNumero.Font = new Font("Verdana", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblNumero.ForeColor = Color.MidnightBlue;
      this.lblNumero.Location = new Point(410, 6);
      this.lblNumero.Name = "lblNumero";
      this.lblNumero.Size = new Size(254, 17);
      this.lblNumero.TabIndex = 23;
      this.lblNumero.Text = "numero";
      this.lblNumero.TextAlign = ContentAlignment.TopRight;
      this.groupBox1.Controls.Add((Control) this.label11);
      this.groupBox1.Controls.Add((Control) this.nudMinuto);
      this.groupBox1.Controls.Add((Control) this.nudHora);
      this.groupBox1.Controls.Add((Control) this.dtpFechaAtencion);
      this.groupBox1.Controls.Add((Control) this.txtFono3);
      this.groupBox1.Controls.Add((Control) this.txtEmail3);
      this.groupBox1.Controls.Add((Control) this.txtFono2);
      this.groupBox1.Controls.Add((Control) this.txtEmail2);
      this.groupBox1.Controls.Add((Control) this.label10);
      this.groupBox1.Controls.Add((Control) this.txtFono);
      this.groupBox1.Controls.Add((Control) this.label9);
      this.groupBox1.Controls.Add((Control) this.txtEmail);
      this.groupBox1.Controls.Add((Control) this.btnSalir);
      this.groupBox1.Controls.Add((Control) this.btnGuardar);
      this.groupBox1.Controls.Add((Control) this.txtContacto);
      this.groupBox1.Controls.Add((Control) this.label7);
      this.groupBox1.Controls.Add((Control) this.label6);
      this.groupBox1.Controls.Add((Control) this.txtNombre);
      this.groupBox1.Controls.Add((Control) this.txtDigito);
      this.groupBox1.Controls.Add((Control) this.txtRut);
      this.groupBox1.Controls.Add((Control) this.label5);
      this.groupBox1.Controls.Add((Control) this.cmbEstado);
      this.groupBox1.Controls.Add((Control) this.label4);
      this.groupBox1.Controls.Add((Control) this.label3);
      this.groupBox1.Controls.Add((Control) this.cmbVendedor);
      this.groupBox1.Controls.Add((Control) this.label1);
      this.groupBox1.Controls.Add((Control) this.txtObservaciones);
      this.groupBox1.Location = new Point(7, 25);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(660, 477);
      this.groupBox1.TabIndex = 27;
      this.groupBox1.TabStop = false;
      this.txtFono3.BackColor = Color.White;
      this.txtFono3.ForeColor = Color.Black;
      this.txtFono3.Location = new Point(473, 114);
      this.txtFono3.Name = "txtFono3";
      this.txtFono3.Size = new Size(169, 20);
      this.txtFono3.TabIndex = 23;
      this.txtEmail3.BackColor = Color.White;
      this.txtEmail3.ForeColor = Color.Black;
      this.txtEmail3.Location = new Point(235, 114);
      this.txtEmail3.Name = "txtEmail3";
      this.txtEmail3.Size = new Size(232, 20);
      this.txtEmail3.TabIndex = 22;
      this.txtEmail3.Text = "@";
      this.txtFono2.BackColor = Color.White;
      this.txtFono2.ForeColor = Color.Black;
      this.txtFono2.Location = new Point(473, 92);
      this.txtFono2.Name = "txtFono2";
      this.txtFono2.Size = new Size(169, 20);
      this.txtFono2.TabIndex = 21;
      this.txtEmail2.BackColor = Color.White;
      this.txtEmail2.ForeColor = Color.Black;
      this.txtEmail2.Location = new Point(235, 92);
      this.txtEmail2.Name = "txtEmail2";
      this.txtEmail2.Size = new Size(232, 20);
      this.txtEmail2.TabIndex = 20;
      this.txtEmail2.Text = "@";
      this.label10.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.label10.Font = new Font("Verdana", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label10.ForeColor = Color.White;
      this.label10.Location = new Point(473, 55);
      this.label10.Name = "label10";
      this.label10.Size = new Size(169, 15);
      this.label10.TabIndex = 19;
      this.label10.Text = "Fono";
      this.txtFono.BackColor = Color.White;
      this.txtFono.ForeColor = Color.Black;
      this.txtFono.Location = new Point(473, 70);
      this.txtFono.Name = "txtFono";
      this.txtFono.Size = new Size(169, 20);
      this.txtFono.TabIndex = 6;
      this.label9.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.label9.Font = new Font("Verdana", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label9.ForeColor = Color.White;
      this.label9.Location = new Point(235, 55);
      this.label9.Name = "label9";
      this.label9.Size = new Size(232, 15);
      this.label9.TabIndex = 17;
      this.label9.Text = "Email";
      this.txtEmail.BackColor = Color.White;
      this.txtEmail.ForeColor = Color.Black;
      this.txtEmail.Location = new Point(235, 70);
      this.txtEmail.Name = "txtEmail";
      this.txtEmail.Size = new Size(232, 20);
      this.txtEmail.TabIndex = 5;
      this.txtEmail.Text = "@";
      this.btnSalir.Font = new Font("Verdana", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnSalir.Location = new Point(458, 443);
      this.btnSalir.Name = "btnSalir";
      this.btnSalir.Size = new Size(186, 23);
      this.btnSalir.TabIndex = 13;
      this.btnSalir.Text = "Salir";
      this.btnSalir.UseVisualStyleBackColor = true;
      this.btnSalir.Click += new EventHandler(this.btnSalir_Click);
      this.btnGuardar.Font = new Font("Verdana", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnGuardar.Location = new Point(458, 387);
      this.btnGuardar.Name = "btnGuardar";
      this.btnGuardar.Size = new Size(186, 37);
      this.btnGuardar.TabIndex = 11;
      this.btnGuardar.Text = "Guardar OT";
      this.btnGuardar.UseVisualStyleBackColor = true;
      this.btnGuardar.Click += new EventHandler(this.btnGuardar_Click);
      this.txtContacto.BackColor = Color.White;
      this.txtContacto.CharacterCasing = CharacterCasing.Upper;
      this.txtContacto.ForeColor = Color.Black;
      this.txtContacto.Location = new Point(17, 70);
      this.txtContacto.Name = "txtContacto";
      this.txtContacto.Size = new Size(208, 20);
      this.txtContacto.TabIndex = 4;
      this.label7.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.label7.Font = new Font("Verdana", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label7.ForeColor = Color.White;
      this.label7.Location = new Point(171, 16);
      this.label7.Name = "label7";
      this.label7.Size = new Size(473, 15);
      this.label7.TabIndex = 14;
      this.label7.Text = "Cliente";
      this.label6.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.label6.Font = new Font("Verdana", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label6.ForeColor = Color.White;
      this.label6.Location = new Point(17, 16);
      this.label6.Name = "label6";
      this.label6.Size = new Size(138, 15);
      this.label6.TabIndex = 13;
      this.label6.Text = "R.U.T";
      this.txtNombre.BackColor = Color.White;
      this.txtNombre.ForeColor = Color.Black;
      this.txtNombre.Location = new Point(171, 32);
      this.txtNombre.Name = "txtNombre";
      this.txtNombre.Size = new Size(473, 20);
      this.txtNombre.TabIndex = 3;
      this.txtDigito.BackColor = Color.White;
      this.txtDigito.ForeColor = Color.Black;
      this.txtDigito.Location = new Point(126, 31);
      this.txtDigito.Name = "txtDigito";
      this.txtDigito.Size = new Size(29, 20);
      this.txtDigito.TabIndex = 2;
      this.txtRut.BackColor = Color.White;
      this.txtRut.ForeColor = Color.Black;
      this.txtRut.Location = new Point(17, 31);
      this.txtRut.Name = "txtRut";
      this.txtRut.Size = new Size(103, 20);
      this.txtRut.TabIndex = 1;
      this.label5.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.label5.Font = new Font("Verdana", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label5.ForeColor = Color.White;
      this.label5.Location = new Point(183, 387);
      this.label5.Name = "label5";
      this.label5.Size = new Size(153, 15);
      this.label5.TabIndex = 9;
      this.label5.Text = "Estado Atencion";
      this.cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbEstado.FormattingEnabled = true;
      this.cmbEstado.Location = new Point(183, 403);
      this.cmbEstado.Name = "cmbEstado";
      this.cmbEstado.Size = new Size(153, 21);
      this.cmbEstado.TabIndex = 10;
      this.label4.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.label4.Font = new Font("Verdana", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label4.ForeColor = Color.White;
      this.label4.Location = new Point(17, 55);
      this.label4.Name = "label4";
      this.label4.Size = new Size(208, 15);
      this.label4.TabIndex = 6;
      this.label4.Text = "Contacto";
      this.label3.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.label3.Font = new Font("Verdana", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label3.ForeColor = Color.White;
      this.label3.Location = new Point(17, 387);
      this.label3.Name = "label3";
      this.label3.Size = new Size(153, 15);
      this.label3.TabIndex = 5;
      this.label3.Text = "Vendedor";
      this.cmbVendedor.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbVendedor.FormattingEnabled = true;
      this.cmbVendedor.Location = new Point(17, 403);
      this.cmbVendedor.Name = "cmbVendedor";
      this.cmbVendedor.Size = new Size(153, 21);
      this.cmbVendedor.TabIndex = 9;
      this.label1.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.label1.Font = new Font("Verdana", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label1.ForeColor = Color.White;
      this.label1.Location = new Point(17, 174);
      this.label1.Name = "label1";
      this.label1.Size = new Size(627, 15);
      this.label1.TabIndex = 2;
      this.label1.Text = "Observacion";
      this.txtObservaciones.CharacterCasing = CharacterCasing.Upper;
      this.txtObservaciones.Location = new Point(17, 189);
      this.txtObservaciones.Multiline = true;
      this.txtObservaciones.Name = "txtObservaciones";
      this.txtObservaciones.Size = new Size(627, 180);
      this.txtObservaciones.TabIndex = 7;
      this.label11.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.label11.Font = new Font("Verdana", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label11.ForeColor = Color.White;
      this.label11.Location = new Point(17, 149);
      this.label11.Name = "label11";
      this.label11.Size = new Size(208, 19);
      this.label11.TabIndex = 29;
      this.label11.Text = "Horario de Atención";
      this.nudMinuto.Location = new Point(275, 149);
      NumericUpDown numericUpDown1 = this.nudMinuto;
      int[] bits1 = new int[4];
      bits1[0] = 59;
      Decimal num1 = new Decimal(bits1);
//      numericUpDown1.Maximum = num1;
      this.nudMinuto.Name = "nudMinuto";
      this.nudMinuto.Size = new Size(47, 20);
      this.nudMinuto.TabIndex = 28;
      this.nudHora.Location = new Point(231, 149);
      NumericUpDown numericUpDown2 = this.nudHora;
      int[] bits2 = new int[4];
      bits2[0] = 12;
      Decimal num2 = new Decimal(bits2);
//      numericUpDown2.Maximum = num2;
      this.nudHora.Name = "nudHora";
      this.nudHora.Size = new Size(38, 20);
      this.nudHora.TabIndex = 27;
      NumericUpDown numericUpDown3 = this.nudHora;
      int[] bits3 = new int[4];
      bits3[0] = 1;
      Decimal num3 = new Decimal(bits3);
//      numericUpDown3.Value = num3;
      this.dtpFechaAtencion.Format = DateTimePickerFormat.Short;
      this.dtpFechaAtencion.Location = new Point(328, 149);
      this.dtpFechaAtencion.Name = "dtpFechaAtencion";
      this.dtpFechaAtencion.Size = new Size(109, 20);
      this.dtpFechaAtencion.TabIndex = 26;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
//      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(223, 233, 245);
      this.ClientSize = new Size(675, 514);
      this.Controls.Add((Control) this.groupBox1);
      this.Controls.Add((Control) this.lblFecha);
      this.Controls.Add((Control) this.lblNumero);
//      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Name = "frmAtencionPreventa";
      this.Text = "Atencion Pre-Venta";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.nudMinuto.EndInit();
      this.nudHora.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
