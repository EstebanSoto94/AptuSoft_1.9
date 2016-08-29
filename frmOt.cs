 
// Type: Aptusoft.frmOt
 
 
// version 1.8.0

using Aptusoft.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Aptusoft
{
  public class frmOt : Form
  {
    private frmOrdenAtencion frmOA = (frmOrdenAtencion) null;
    private frmModuloFacturacionAptusoft frmMFF = (frmModuloFacturacionAptusoft) null;
    private IContainer components = (IContainer) null;
    private int idCliente;
    private string usuario;
    private Label lblNumero;
    private Label label8;
    private GroupBox groupBox1;
    private Label label9;
    private TextBox txtEmail;
    private Button btnModificar;
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
    private Label label2;
    private Label label1;
    private TextBox txtSolucion;
    private TextBox txtRequerimiento;
    private Label label10;
    private TextBox txtFono;
    private Label lblFecha;
    private NumericUpDown nudMinuto;
    private NumericUpDown nudHora;
    private DateTimePicker dtpFechaAtencion;
    private Label label11;
    private Label label12;
    private Panel panel2;
    private ComboBox cmbIngresadoPor;
    private Label label13;
    private Panel panel1;
    private Panel panel3;
    private ComboBox cmbTipoSolicitud;
    private Label label14;
    private Panel panel4;
    private DataGridView dgvDatos;
    private DataGridViewTextBoxColumn FechaIngreso;
    private DataGridViewTextBoxColumn Requerimiento;
    private DataGridViewTextBoxColumn Solucion;
    private DataGridViewTextBoxColumn Tecnico;
    private Label label15;

    public frmOt()
    {
      this.InitializeComponent();
      this.dgvDatos.AutoGenerateColumns = false;
      this.iniciaFormulario();
    }

    public frmOt(int ic, string r, string d, string rs, string email, string fono, string contacto, frmOrdenAtencion oa)
    {
      this.InitializeComponent();
      this.dgvDatos.AutoGenerateColumns = false;
      this.iniciaFormulario();
      this.idCliente = ic;
      this.txtRut.Text = r;
      this.txtDigito.Text = d;
      this.txtNombre.Text = rs;
      this.txtEmail.Text = email;
      this.txtFono.Text = fono;
      this.txtContacto.Text = contacto;
      this.frmOA = oa;
      this.cargalistaOrdenAtencion();
    }

    public frmOt(int idOrdAt, frmOrdenAtencion oa)
    {
      this.InitializeComponent();
      this.dgvDatos.AutoGenerateColumns = false;
      this.frmOA = oa;
      this.iniciaFormulario();
      this.buscaOrdeAtencion(idOrdAt);
      this.cargalistaOrdenAtencion();
    }

    public frmOt(int ic, string r, string d, string rs, string email, string fono, string contacto, frmModuloFacturacionAptusoft mff)
    {
      this.InitializeComponent();
      this.dgvDatos.AutoGenerateColumns = false;
      this.iniciaFormulario();
      this.idCliente = ic;
      this.txtRut.Text = r;
      this.txtDigito.Text = d;
      this.txtNombre.Text = rs;
      this.txtEmail.Text = email;
      this.txtFono.Text = fono;
      this.txtContacto.Text = contacto;
      this.frmMFF = mff;
      this.cargalistaOrdenAtencion();
    }

    public frmOt(int idOrdAt, frmModuloFacturacionAptusoft mff)
    {
      this.InitializeComponent();
      this.dgvDatos.AutoGenerateColumns = false;
      this.frmMFF = mff;
      this.iniciaFormulario();
      this.buscaOrdeAtencion(idOrdAt);
      this.cargalistaOrdenAtencion();
    }

    private void cargalistaOrdenAtencion()
    {
      List<OrdenAtencionVO> list = new List<OrdenAtencionVO>();
      this.dgvDatos.DataSource = (object) new OrdenAtencion().listaOrdenAtencion(this.idCliente);
    }

    private void iniciaFormulario()
    {
      this.lblFecha.Text = DateTime.Now.ToShortDateString();
      this.cmbTipoSolicitud.SelectedIndex = 0;
      this.cargaVendedores();
      this.cargaVendedoresIngresadoPor();
      this.cargaEstado();
      this.cargaFolio();
      this.txtRut.Enabled = false;
      this.txtDigito.Enabled = false;
      this.txtNombre.Enabled = false;
      this.txtContacto.Clear();
      this.txtEmail.Clear();
      this.txtEmail.Text = "@";
      this.txtFono.Clear();
      this.txtRequerimiento.Clear();
      this.txtSolucion.Clear();
      this.txtRequerimiento.Focus();
      this.btnGuardar.Enabled = true;
      this.btnModificar.Enabled = false;
      this.usuario = frmMenuPrincipal.listaUsuario[0].NombreUsuario;
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void cargaVendedores()
    {
      this.cmbVendedor.DataSource = (object) new Vendedor().listaVendedoresVenta();
      this.cmbVendedor.ValueMember = "idVendedor";
      this.cmbVendedor.DisplayMember = "nombre";
      this.cmbVendedor.SelectedValue = (object) 0;
    }

    private void cargaVendedoresIngresadoPor()
    {
      this.cmbIngresadoPor.DataSource = (object) new Vendedor().listaVendedoresVenta();
      this.cmbIngresadoPor.ValueMember = "idVendedor";
      this.cmbIngresadoPor.DisplayMember = "nombre";
      this.cmbIngresadoPor.SelectedValue = (object) 0;
    }

    private void cargaEstado()
    {
      this.cmbEstado.DataSource = (object) new CargaMaestros().listaEstadoOT();
      this.cmbEstado.ValueMember = "IdBodega";
      this.cmbEstado.DisplayMember = "NombreBodega";
      this.cmbEstado.SelectedValue = (object) 1;
    }

    private void cargaFolio()
    {
      this.lblNumero.Text = new OrdenAtencion().numeroAtencion();
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
      if (this.txtContacto.Text.Length > 0 && this.txtRequerimiento.Text.Length > 0 && (this.cmbVendedor.SelectedValue.ToString() != "0" && this.cmbEstado.SelectedValue.ToString() != "0") && this.cmbTipoSolicitud.Text != "[SELECCIONE]" && this.cmbIngresadoPor.SelectedValue.ToString() != "0")
      {
        OrdenAtencionVO oa = new OrdenAtencionVO();
        oa.FechaIngreso = DateTime.Now;
        oa.IdCliente = this.idCliente;
        oa.Rut = this.txtRut.Text;
        oa.Digito = this.txtDigito.Text;
        oa.RazonSocial = this.txtNombre.Text;
        oa.Contacto = this.txtContacto.Text.Trim().ToUpper();
        oa.Email = this.txtEmail.Text.Trim();
        oa.Fono = this.txtFono.Text.Trim();
        oa.Requerimiento = this.txtRequerimiento.Text.Trim().ToUpper();
        oa.Solucion = this.txtSolucion.Text.Trim().ToUpper();
        oa.IdTecnico = Convert.ToInt32(this.cmbVendedor.SelectedValue.ToString());
        oa.Tecnico = this.cmbVendedor.Text;
        oa.Estado = this.cmbEstado.Text;
        oa.Usuario = this.usuario;
        oa.IngresadoPor = this.cmbIngresadoPor.Text;
        oa.TipoSolicitud = this.cmbTipoSolicitud.Text;
        DateTime dateTime = new DateTime(this.dtpFechaAtencion.Value.Year, this.dtpFechaAtencion.Value.Month, this.dtpFechaAtencion.Value.Day, Convert.ToInt32(this.nudHora.Value), Convert.ToInt32(this.nudMinuto.Value), DateTime.Now.TimeOfDay.Seconds);
        oa.FechaAtencion = dateTime;
        OrdenAtencion ordenAtencion = new OrdenAtencion();
        try
        {
          ordenAtencion.agregaOrdenAtencion(oa);
          int num = (int) MessageBox.Show("Orden de Atención Registrada", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          this.enviaCorreo();
          if (this.frmOA != null)
            this.frmOA.buscaClienteCodigo(this.idCliente);
          this.Close();
        }
        catch (Exception ex)
        {
          int num = (int) MessageBox.Show("Error al Guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
      }
      else
      {
        int num1 = (int) MessageBox.Show("Debe Ingresar Todos los Datos!!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void btnModificar_Click(object sender, EventArgs e)
    {
      if (this.txtContacto.Text.Length > 0 && this.txtRequerimiento.Text.Length > 0 && (this.cmbVendedor.SelectedValue.ToString() != "0" && this.cmbEstado.SelectedValue.ToString() != "0") && this.cmbTipoSolicitud.Text != "[SELECCIONE]" && this.cmbIngresadoPor.SelectedValue.ToString() != "0")
      {
        OrdenAtencionVO oa = new OrdenAtencionVO();
        oa.IdOrdenAtencion = Convert.ToInt32(this.lblNumero.Text);
        DateTime dateTime1 =DateTime.Now;
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        DateTime local = @dateTime1;
        int year = this.dtpFechaAtencion.Value.Year;
        DateTime dateTime2 = this.dtpFechaAtencion.Value;
        int month = dateTime2.Month;
        dateTime2 = this.dtpFechaAtencion.Value;
        int day = dateTime2.Day;
        int hour = Convert.ToInt32(this.nudHora.Value);
        int minute = Convert.ToInt32(this.nudMinuto.Value);
        int seconds = DateTime.Now.TimeOfDay.Seconds;
        // ISSUE: explicit reference operation
        local = new DateTime(year, month, day, hour, minute, seconds);
        oa.FechaAtencion = dateTime1;
        oa.Contacto = this.txtContacto.Text.Trim().ToUpper();
        oa.Email = this.txtEmail.Text.Trim();
        oa.Fono = this.txtFono.Text.Trim();
        oa.Requerimiento = this.txtRequerimiento.Text.Trim().ToUpper();
        oa.Solucion = this.txtSolucion.Text.Trim().ToUpper();
        oa.IdTecnico = Convert.ToInt32(this.cmbVendedor.SelectedValue.ToString());
        oa.Tecnico = this.cmbVendedor.Text;
        oa.Estado = this.cmbEstado.Text;
        oa.Usuario = this.usuario;
        oa.IngresadoPor = this.cmbIngresadoPor.Text;
        oa.TipoSolicitud = this.cmbTipoSolicitud.Text;
        OrdenAtencion ordenAtencion = new OrdenAtencion();
        try
        {
          ordenAtencion.modificaOrdenAtencion(oa);
          int num = (int) MessageBox.Show("Orden de Atención Modificada", "Modifica", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          if (this.frmOA != null)
            this.frmOA.buscaClienteCodigo(this.idCliente);
          this.enviaCorreo();
          this.Close();
        }
        catch (Exception ex)
        {
          int num = (int) MessageBox.Show("Error al Modificar: " + ex.Message);
        }
      }
      else
      {
        int num1 = (int) MessageBox.Show("Debe Ingresar Todos los Datos!!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void buscaOrdeAtencion(int idOrd)
    {
      OrdenAtencionVO ordenAtencionVo = new OrdenAtencion().buscaOrdenAtencion(idOrd);
      this.idCliente = ordenAtencionVo.IdCliente;
      this.lblNumero.Text = ordenAtencionVo.IdOrdenAtencion.ToString();
      this.txtRut.Text = ordenAtencionVo.Rut;
      this.txtDigito.Text = ordenAtencionVo.Digito;
      this.txtNombre.Text = ordenAtencionVo.RazonSocial;
      this.txtContacto.Text = ordenAtencionVo.Contacto;
      this.txtEmail.Text = ordenAtencionVo.Email;
      this.txtFono.Text = ordenAtencionVo.Fono;
      this.txtRequerimiento.Text = ordenAtencionVo.Requerimiento;
      this.txtSolucion.Text = ordenAtencionVo.Solucion;
      this.cmbVendedor.Text = ordenAtencionVo.Tecnico;
      this.cmbEstado.Text = ordenAtencionVo.Estado;
      this.btnGuardar.Enabled = false;
      this.btnModificar.Enabled = true;
      DateTime fechaAtencion = ordenAtencionVo.FechaAtencion;
      this.nudHora.Value = Convert.ToDecimal(fechaAtencion.Hour.ToString("N0"));
      this.nudMinuto.Value = Convert.ToDecimal(fechaAtencion.Minute.ToString("N0"));
      this.dtpFechaAtencion.Value = fechaAtencion;
      this.lblFecha.Text = ordenAtencionVo.FechaIngreso.ToString();
      this.cmbTipoSolicitud.Text = ordenAtencionVo.TipoSolicitud;
      this.cmbIngresadoPor.Text = ordenAtencionVo.IngresadoPor;
    }

    private void enviaCorreo()
    {
      if (DialogResult.Yes != MessageBox.Show("¿ Desea enviar la Orden de Atención por correo ?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
        return;
      OrdenAtencionVO ate = new OrdenAtencionVO();
      ate.IdOrdenAtencion = Convert.ToInt32(this.lblNumero.Text);
      ate.FechaIngreso = Convert.ToDateTime(this.lblFecha.Text);
      DateTime dateTime = new DateTime(this.dtpFechaAtencion.Value.Year, this.dtpFechaAtencion.Value.Month, this.dtpFechaAtencion.Value.Day, Convert.ToInt32(this.nudHora.Value), Convert.ToInt32(this.nudMinuto.Value), DateTime.Now.TimeOfDay.Seconds);
      ate.FechaAtencion = dateTime;
      ate.Rut = this.txtRut.Text;
      ate.Digito = this.txtDigito.Text;
      ate.RazonSocial = this.txtNombre.Text;
      ate.Contacto = this.txtContacto.Text.Trim().ToLower();
      ate.Requerimiento = this.txtRequerimiento.Text.Trim().ToLower();
      ate.Solucion = this.txtSolucion.Text.Trim().ToLower();
      ate.Tecnico = this.cmbVendedor.Text.ToLower();
      ate.Estado = this.cmbEstado.Text.ToLower();
      ate.Email = this.txtEmail.Text.Trim();
      ate.Fono = this.txtFono.Text;
      int num = (int) new Correo(ate).ShowDialog();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      DataGridViewCellStyle gridViewCellStyle = new DataGridViewCellStyle();
      this.lblNumero = new Label();
      this.label8 = new Label();
      this.groupBox1 = new GroupBox();
      this.panel3 = new Panel();
      this.label6 = new Label();
      this.label4 = new Label();
      this.txtRut = new TextBox();
      this.label10 = new Label();
      this.txtDigito = new TextBox();
      this.txtFono = new TextBox();
      this.txtNombre = new TextBox();
      this.label9 = new Label();
      this.label7 = new Label();
      this.txtEmail = new TextBox();
      this.txtContacto = new TextBox();
      this.panel2 = new Panel();
      this.cmbTipoSolicitud = new ComboBox();
      this.label14 = new Label();
      this.cmbIngresadoPor = new ComboBox();
      this.txtRequerimiento = new TextBox();
      this.label13 = new Label();
      this.label1 = new Label();
      this.label11 = new Label();
      this.dtpFechaAtencion = new DateTimePicker();
      this.nudMinuto = new NumericUpDown();
      this.nudHora = new NumericUpDown();
      this.panel1 = new Panel();
      this.label2 = new Label();
      this.txtSolucion = new TextBox();
      this.cmbVendedor = new ComboBox();
      this.label3 = new Label();
      this.cmbEstado = new ComboBox();
      this.label5 = new Label();
      this.btnModificar = new Button();
      this.btnSalir = new Button();
      this.btnGuardar = new Button();
      this.lblFecha = new Label();
      this.label12 = new Label();
      this.panel4 = new Panel();
      this.dgvDatos = new DataGridView();
      this.FechaIngreso = new DataGridViewTextBoxColumn();
      this.Requerimiento = new DataGridViewTextBoxColumn();
      this.Solucion = new DataGridViewTextBoxColumn();
      this.Tecnico = new DataGridViewTextBoxColumn();
      this.label15 = new Label();
      this.groupBox1.SuspendLayout();
      this.panel3.SuspendLayout();
      this.panel2.SuspendLayout();
      this.nudMinuto.BeginInit();
      this.nudHora.BeginInit();
      this.panel1.SuspendLayout();
      this.panel4.SuspendLayout();
      ((ISupportInitialize) this.dgvDatos).BeginInit();
      this.SuspendLayout();
      this.lblNumero.Font = new Font("Verdana", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblNumero.ForeColor = Color.SteelBlue;
      this.lblNumero.Location = new Point(597, 10);
      this.lblNumero.Name = "lblNumero";
      this.lblNumero.Size = new Size(73, 15);
      this.lblNumero.TabIndex = 19;
      this.lblNumero.Text = "A";
      this.lblNumero.TextAlign = ContentAlignment.TopRight;
      this.label8.AutoSize = true;
      this.label8.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label8.ForeColor = Color.SteelBlue;
      this.label8.Location = new Point(439, 10);
      this.label8.Name = "label8";
      this.label8.Size = new Size(153, 15);
      this.label8.TabIndex = 20;
      this.label8.Text = "Orden de Atencion N° :";
      this.groupBox1.Controls.Add((Control) this.panel3);
      this.groupBox1.Controls.Add((Control) this.panel2);
      this.groupBox1.Controls.Add((Control) this.panel1);
      this.groupBox1.Location = new Point(4, 28);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(666, 502);
      this.groupBox1.TabIndex = 18;
      this.groupBox1.TabStop = false;
      this.panel3.BackColor = Color.FromArgb(223, 233, 245);
      this.panel3.Controls.Add((Control) this.label6);
      this.panel3.Controls.Add((Control) this.label4);
      this.panel3.Controls.Add((Control) this.txtRut);
      this.panel3.Controls.Add((Control) this.label10);
      this.panel3.Controls.Add((Control) this.txtDigito);
      this.panel3.Controls.Add((Control) this.txtFono);
      this.panel3.Controls.Add((Control) this.txtNombre);
      this.panel3.Controls.Add((Control) this.label9);
      this.panel3.Controls.Add((Control) this.label7);
      this.panel3.Controls.Add((Control) this.txtEmail);
      this.panel3.Controls.Add((Control) this.txtContacto);
      this.panel3.Location = new Point(8, 12);
      this.panel3.Name = "panel3";
      this.panel3.Size = new Size(646, 91);
      this.panel3.TabIndex = 24;
      this.label6.BackColor = Color.LightSkyBlue;
      this.label6.Font = new Font("Verdana", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label6.ForeColor = Color.Black;
      this.label6.Location = new Point(10, 11);
      this.label6.Name = "label6";
      this.label6.Size = new Size(138, 15);
      this.label6.TabIndex = 13;
      this.label6.Text = "R.U.T";
      this.label4.BackColor = Color.LightSkyBlue;
      this.label4.Font = new Font("Verdana", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label4.ForeColor = Color.Black;
      this.label4.Location = new Point(10, 50);
      this.label4.Name = "label4";
      this.label4.Size = new Size(208, 15);
      this.label4.TabIndex = 6;
      this.label4.Text = "Contacto";
      this.txtRut.Location = new Point(10, 26);
      this.txtRut.Name = "txtRut";
      this.txtRut.Size = new Size(103, 20);
      this.txtRut.TabIndex = 1;
      this.label10.BackColor = Color.LightSkyBlue;
      this.label10.Font = new Font("Verdana", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label10.ForeColor = Color.Black;
      this.label10.Location = new Point(468, 50);
      this.label10.Name = "label10";
      this.label10.Size = new Size(169, 15);
      this.label10.TabIndex = 19;
      this.label10.Text = "Fono";
      this.txtDigito.Location = new Point(119, 26);
      this.txtDigito.Name = "txtDigito";
      this.txtDigito.Size = new Size(29, 20);
      this.txtDigito.TabIndex = 2;
      this.txtFono.Location = new Point(468, 65);
      this.txtFono.Name = "txtFono";
      this.txtFono.Size = new Size(169, 20);
      this.txtFono.TabIndex = 6;
      this.txtNombre.Location = new Point(164, 27);
      this.txtNombre.Name = "txtNombre";
      this.txtNombre.Size = new Size(473, 20);
      this.txtNombre.TabIndex = 3;
      this.label9.BackColor = Color.LightSkyBlue;
      this.label9.Font = new Font("Verdana", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label9.ForeColor = Color.Black;
      this.label9.Location = new Point(230, 50);
      this.label9.Name = "label9";
      this.label9.Size = new Size(232, 15);
      this.label9.TabIndex = 17;
      this.label9.Text = "Email";
      this.label7.BackColor = Color.LightSkyBlue;
      this.label7.Font = new Font("Verdana", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label7.ForeColor = Color.Black;
      this.label7.Location = new Point(164, 11);
      this.label7.Name = "label7";
      this.label7.Size = new Size(473, 15);
      this.label7.TabIndex = 14;
      this.label7.Text = "Cliente";
      this.txtEmail.Location = new Point(230, 65);
      this.txtEmail.Name = "txtEmail";
      this.txtEmail.Size = new Size(232, 20);
      this.txtEmail.TabIndex = 5;
      this.txtEmail.Text = "@";
      this.txtContacto.Location = new Point(10, 65);
      this.txtContacto.Name = "txtContacto";
      this.txtContacto.Size = new Size(208, 20);
      this.txtContacto.TabIndex = 4;
      this.panel2.BackColor = Color.FromArgb(223, 233, 245);
      this.panel2.Controls.Add((Control) this.cmbTipoSolicitud);
      this.panel2.Controls.Add((Control) this.label14);
      this.panel2.Controls.Add((Control) this.cmbIngresadoPor);
      this.panel2.Controls.Add((Control) this.txtRequerimiento);
      this.panel2.Controls.Add((Control) this.label13);
      this.panel2.Controls.Add((Control) this.label1);
      this.panel2.Controls.Add((Control) this.label11);
      this.panel2.Controls.Add((Control) this.dtpFechaAtencion);
      this.panel2.Controls.Add((Control) this.nudMinuto);
      this.panel2.Controls.Add((Control) this.nudHora);
      this.panel2.Location = new Point(8, 106);
      this.panel2.Name = "panel2";
      this.panel2.Size = new Size(646, 194);
      this.panel2.TabIndex = 23;
      this.cmbTipoSolicitud.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbTipoSolicitud.FormattingEnabled = true;
      this.cmbTipoSolicitud.Items.AddRange(new object[10]
      {
        (object) "[SELECCIONE]",
        (object) "SOPORTE",
        (object) "SOPORTE NIVEL DIOS",
        (object) "DESARROLLO ESPECIAL",
        (object) "CAPACITACION",
        (object) "VENTA",
        (object) "VISITA TECNICA",
        (object) "DEMO",
        (object) "ACTUALIZACION",
        (object) "TOMA DE REQUERIMIENTOS"
      });
      this.cmbTipoSolicitud.Location = new Point(233, 28);
      this.cmbTipoSolicitud.Name = "cmbTipoSolicitud";
      this.cmbTipoSolicitud.Size = new Size(218, 21);
      this.cmbTipoSolicitud.TabIndex = 30;
      this.label14.BackColor = Color.LightSkyBlue;
      this.label14.Font = new Font("Verdana", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label14.ForeColor = Color.Black;
      this.label14.Location = new Point(233, 12);
      this.label14.Name = "label14";
      this.label14.Size = new Size(218, 15);
      this.label14.TabIndex = 29;
      this.label14.Text = "Tipo de Solicitud";
      this.cmbIngresadoPor.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbIngresadoPor.FormattingEnabled = true;
      this.cmbIngresadoPor.Location = new Point(9, 28);
      this.cmbIngresadoPor.Name = "cmbIngresadoPor";
      this.cmbIngresadoPor.Size = new Size(218, 21);
      this.cmbIngresadoPor.TabIndex = 28;
      this.txtRequerimiento.Location = new Point(9, 72);
      this.txtRequerimiento.Multiline = true;
      this.txtRequerimiento.Name = "txtRequerimiento";
      this.txtRequerimiento.Size = new Size(627, 94);
      this.txtRequerimiento.TabIndex = 7;
      this.label13.BackColor = Color.LightSkyBlue;
      this.label13.Font = new Font("Verdana", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label13.ForeColor = Color.Black;
      this.label13.Location = new Point(9, 12);
      this.label13.Name = "label13";
      this.label13.Size = new Size(218, 15);
      this.label13.TabIndex = 27;
      this.label13.Text = "Ingresado Por";
      this.label1.BackColor = Color.LightSkyBlue;
      this.label1.Font = new Font("Verdana", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label1.ForeColor = Color.Black;
      this.label1.Location = new Point(9, 56);
      this.label1.Name = "label1";
      this.label1.Size = new Size(627, 15);
      this.label1.TabIndex = 2;
      this.label1.Text = "Requerimiento";
      this.label11.BackColor = Color.LightSkyBlue;
      this.label11.Font = new Font("Verdana", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label11.ForeColor = Color.Black;
      this.label11.Location = new Point(9, 169);
      this.label11.Name = "label11";
      this.label11.Size = new Size(208, 19);
      this.label11.TabIndex = 25;
      this.label11.Text = "Horario de Atención";
      this.dtpFechaAtencion.Format = DateTimePickerFormat.Short;
      this.dtpFechaAtencion.Location = new Point(323, 169);
      this.dtpFechaAtencion.Name = "dtpFechaAtencion";
      this.dtpFechaAtencion.Size = new Size(109, 20);
      this.dtpFechaAtencion.TabIndex = 22;
      this.nudMinuto.Location = new Point(270, 169);
      NumericUpDown numericUpDown1 = this.nudMinuto;
      int[] bits1 = new int[4];
      bits1[0] = 59;
      Decimal num1 = new Decimal(bits1);
//      numericUpDown1.Maximum = num1;
      this.nudMinuto.Name = "nudMinuto";
      this.nudMinuto.Size = new Size(47, 20);
      this.nudMinuto.TabIndex = 24;
      this.nudHora.Location = new Point(226, 169);
      NumericUpDown numericUpDown2 = this.nudHora;
      int[] bits2 = new int[4];
      bits2[0] = 12;
      Decimal num2 = new Decimal(bits2);
//      numericUpDown2.Maximum = num2;
      this.nudHora.Name = "nudHora";
      this.nudHora.Size = new Size(38, 20);
      this.nudHora.TabIndex = 23;
      NumericUpDown numericUpDown3 = this.nudHora;
      int[] bits3 = new int[4];
      bits3[0] = 1;
      Decimal num3 = new Decimal(bits3);
//      numericUpDown3.Value = num3;
      this.panel1.BackColor = Color.FromArgb(223, 233, 245);
      this.panel1.Controls.Add((Control) this.label2);
      this.panel1.Controls.Add((Control) this.txtSolucion);
      this.panel1.Controls.Add((Control) this.cmbVendedor);
      this.panel1.Controls.Add((Control) this.label3);
      this.panel1.Controls.Add((Control) this.cmbEstado);
      this.panel1.Controls.Add((Control) this.label5);
      this.panel1.Location = new Point(8, 303);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(646, 191);
      this.panel1.TabIndex = 23;
      this.label2.BackColor = Color.LightSkyBlue;
      this.label2.Font = new Font("Verdana", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label2.ForeColor = Color.Black;
      this.label2.Location = new Point(8, 12);
      this.label2.Name = "label2";
      this.label2.Size = new Size(627, 15);
      this.label2.TabIndex = 3;
      this.label2.Text = "Solucion";
      this.txtSolucion.Location = new Point(8, 28);
      this.txtSolucion.Multiline = true;
      this.txtSolucion.Name = "txtSolucion";
      this.txtSolucion.Size = new Size(627, 109);
      this.txtSolucion.TabIndex = 8;
      this.cmbVendedor.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbVendedor.FormattingEnabled = true;
      this.cmbVendedor.Location = new Point(8, 161);
      this.cmbVendedor.Name = "cmbVendedor";
      this.cmbVendedor.Size = new Size(218, 21);
      this.cmbVendedor.TabIndex = 9;
      this.label3.BackColor = Color.LightSkyBlue;
      this.label3.Font = new Font("Verdana", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label3.ForeColor = Color.Black;
      this.label3.Location = new Point(8, 145);
      this.label3.Name = "label3";
      this.label3.Size = new Size(218, 15);
      this.label3.TabIndex = 5;
      this.label3.Text = "Tecnico";
      this.cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbEstado.FormattingEnabled = true;
      this.cmbEstado.Location = new Point(263, 161);
      this.cmbEstado.Name = "cmbEstado";
      this.cmbEstado.Size = new Size(153, 21);
      this.cmbEstado.TabIndex = 10;
      this.label5.BackColor = Color.LightSkyBlue;
      this.label5.Font = new Font("Verdana", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label5.ForeColor = Color.Black;
      this.label5.Location = new Point(263, 145);
      this.label5.Name = "label5";
      this.label5.Size = new Size(153, 15);
      this.label5.TabIndex = 9;
      this.label5.Text = "Estado OT";
      this.btnModificar.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnModificar.Image = (Image) Resources.modificar_48;
      this.btnModificar.ImageAlign = ContentAlignment.TopCenter;
      this.btnModificar.Location = new Point(80, 536);
      this.btnModificar.Name = "btnModificar";
      this.btnModificar.Size = new Size(70, 70);
      this.btnModificar.TabIndex = 12;
      this.btnModificar.Text = "Modificar";
      this.btnModificar.TextAlign = ContentAlignment.BottomCenter;
      this.btnModificar.UseVisualStyleBackColor = true;
      this.btnModificar.Click += new EventHandler(this.btnModificar_Click);
      this.btnSalir.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnSalir.Image = (Image) Resources.salir_de_mi_perfil_icono_3964_48;
      this.btnSalir.ImageAlign = ContentAlignment.TopCenter;
      this.btnSalir.Location = new Point(600, 536);
      this.btnSalir.Name = "btnSalir";
      this.btnSalir.Size = new Size(70, 70);
      this.btnSalir.TabIndex = 13;
      this.btnSalir.Text = "Salir";
      this.btnSalir.TextAlign = ContentAlignment.BottomCenter;
      this.btnSalir.UseVisualStyleBackColor = true;
      this.btnSalir.Click += new EventHandler(this.btnSalir_Click);
      this.btnGuardar.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnGuardar.Image = (Image) Resources.guardar_documento_icono_7840_48;
      this.btnGuardar.ImageAlign = ContentAlignment.TopCenter;
      this.btnGuardar.Location = new Point(4, 536);
      this.btnGuardar.Name = "btnGuardar";
      this.btnGuardar.Size = new Size(70, 70);
      this.btnGuardar.TabIndex = 11;
      this.btnGuardar.Text = "Guardar";
      this.btnGuardar.TextAlign = ContentAlignment.BottomCenter;
      this.btnGuardar.UseVisualStyleBackColor = true;
      this.btnGuardar.Click += new EventHandler(this.btnGuardar_Click);
      this.lblFecha.AutoSize = true;
      this.lblFecha.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblFecha.ForeColor = Color.SteelBlue;
      this.lblFecha.Location = new Point(113, 9);
      this.lblFecha.Name = "lblFecha";
      this.lblFecha.Size = new Size(42, 15);
      this.lblFecha.TabIndex = 21;
      this.lblFecha.Text = "fecha";
      this.label12.AutoSize = true;
      this.label12.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label12.ForeColor = Color.SteelBlue;
      this.label12.Location = new Point(12, 9);
      this.label12.Name = "label12";
      this.label12.Size = new Size(95, 15);
      this.label12.TabIndex = 22;
      this.label12.Text = "Ingresado el :";
      this.panel4.Controls.Add((Control) this.dgvDatos);
      this.panel4.Location = new Point(676, 34);
      this.panel4.Name = "panel4";
      this.panel4.Size = new Size(663, 496);
      this.panel4.TabIndex = 23;
      this.dgvDatos.AllowUserToAddRows = false;
      this.dgvDatos.AllowUserToDeleteRows = false;
      gridViewCellStyle.BackColor = Color.Lavender;
      this.dgvDatos.AlternatingRowsDefaultCellStyle = gridViewCellStyle;
      this.dgvDatos.BackgroundColor = SystemColors.ActiveCaption;
      this.dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvDatos.Columns.AddRange((DataGridViewColumn) this.FechaIngreso, (DataGridViewColumn) this.Requerimiento, (DataGridViewColumn) this.Solucion, (DataGridViewColumn) this.Tecnico);
      this.dgvDatos.Location = new Point(6, 5);
      this.dgvDatos.Name = "dgvDatos";
      this.dgvDatos.ReadOnly = true;
      this.dgvDatos.RowHeadersVisible = false;
      this.dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvDatos.Size = new Size(654, 488);
      this.dgvDatos.TabIndex = 0;
      this.FechaIngreso.DataPropertyName = "FechaIngreso";
      this.FechaIngreso.HeaderText = "Fecha";
      this.FechaIngreso.Name = "FechaIngreso";
      this.FechaIngreso.ReadOnly = true;
      this.FechaIngreso.Width = 70;
      this.Requerimiento.DataPropertyName = "Requerimiento";
      this.Requerimiento.HeaderText = "Requerimiento";
      this.Requerimiento.Name = "Requerimiento";
      this.Requerimiento.ReadOnly = true;
      this.Requerimiento.Width = 300;
      this.Solucion.DataPropertyName = "Solucion";
      this.Solucion.HeaderText = "Solucion";
      this.Solucion.Name = "Solucion";
      this.Solucion.ReadOnly = true;
      this.Solucion.Width = 300;
      this.Tecnico.DataPropertyName = "Tecnico";
      this.Tecnico.HeaderText = "Tecnico";
      this.Tecnico.Name = "Tecnico";
      this.Tecnico.ReadOnly = true;
      this.label15.AutoSize = true;
      this.label15.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label15.ForeColor = Color.SteelBlue;
      this.label15.Location = new Point(1142, 10);
      this.label15.Name = "label15";
      this.label15.Size = new Size(194, 15);
      this.label15.TabIndex = 24;
      this.label15.Text = "Orden de Atencion Anteriores";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
//      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
      this.ClientSize = new Size(1351, 612);
      this.Controls.Add((Control) this.label15);
      this.Controls.Add((Control) this.panel4);
      this.Controls.Add((Control) this.label12);
      this.Controls.Add((Control) this.lblFecha);
      this.Controls.Add((Control) this.lblNumero);
      this.Controls.Add((Control) this.label8);
      this.Controls.Add((Control) this.groupBox1);
      this.Controls.Add((Control) this.btnGuardar);
      this.Controls.Add((Control) this.btnSalir);
      this.Controls.Add((Control) this.btnModificar);
//      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Name = "frmOt";
      this.ShowIcon = false;
      this.Text = "Orden de Atención";
      this.groupBox1.ResumeLayout(false);
      this.panel3.ResumeLayout(false);
      this.panel3.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.nudMinuto.EndInit();
      this.nudHora.EndInit();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panel4.ResumeLayout(false);
      ((ISupportInitialize) this.dgvDatos).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
