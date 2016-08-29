 
// Type: Aptusoft.frmModuloFiscal
 
 
// version 1.8.0

using AxOCXSAM350Lib;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Aptusoft
{
  public class frmModuloFiscal : Form
  {
    private IContainer components = (IContainer) null;
    private int val = 0;
    private short _puertoImpresoraFiscal = (short) 0;
    private Button btnCierreJornada;
    private AxOcxsam350 ocxFiscal;
    private Button btnInformeX;
    private Button btnZSegunFecha;
    private GroupBox groupBox1;
    private GroupBox groupBox2;
    private Label label2;
    private Label label1;
    private DateTimePicker dtpHasta;
    private DateTimePicker dtpDesde;
    private Button btnTransaccionSegunFecha;
    private GroupBox groupBox3;
    private Button btnTransaccionSegunNumero;
    private Button btnZSegunNumero;
    private Label label3;
    private Label label4;
    private TextBox txtHasta;
    private TextBox txtDesde;
    private Button btnCambiarHora;
    private Panel panel1;
    private Button btnDesbloquearImpresora;
    private Button button1;
    private Button btnHorasJornada;

    public frmModuloFiscal()
    {
      this.InitializeComponent();
      this.cargaOpcionesDocumentos();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmModuloFiscal));
      this.btnCierreJornada = new Button();
      this.ocxFiscal = new AxOcxsam350();
      this.btnInformeX = new Button();
      this.btnZSegunFecha = new Button();
      this.groupBox1 = new GroupBox();
      this.btnTransaccionSegunFecha = new Button();
      this.label2 = new Label();
      this.label1 = new Label();
      this.dtpHasta = new DateTimePicker();
      this.dtpDesde = new DateTimePicker();
      this.groupBox2 = new GroupBox();
      this.groupBox3 = new GroupBox();
      this.btnTransaccionSegunNumero = new Button();
      this.btnZSegunNumero = new Button();
      this.label3 = new Label();
      this.label4 = new Label();
      this.txtHasta = new TextBox();
      this.txtDesde = new TextBox();
      this.btnCambiarHora = new Button();
      this.panel1 = new Panel();
      this.btnDesbloquearImpresora = new Button();
      this.button1 = new Button();
      this.btnHorasJornada = new Button();
      ((ISupportInitialize) this.ocxFiscal).BeginInit();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      this.btnCierreJornada.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnCierreJornada.Location = new Point(22, 19);
      this.btnCierreJornada.Name = "btnCierreJornada";
      this.btnCierreJornada.Size = new Size(342, 23);
      this.btnCierreJornada.TabIndex = 0;
      this.btnCierreJornada.Text = "CIERRE DE JORNADA FISCAL - INFORME Z";
      this.btnCierreJornada.UseVisualStyleBackColor = true;
      this.btnCierreJornada.Click += new EventHandler(this.btnCierreJornada_Click);
      ((AxHost) this.ocxFiscal).Enabled = true;
      ((Control) this.ocxFiscal).Location = new Point(12, 528);
      ((Control) this.ocxFiscal).Name = "ocxFiscal";
      ((AxHost) this.ocxFiscal).OcxState = (AxHost.State) componentResourceManager.GetObject("ocxFiscal.OcxState");
      ((Control) this.ocxFiscal).Size = new Size(100, 50);
      ((Control) this.ocxFiscal).TabIndex = 1;
      ((Control) this.ocxFiscal).Visible = false;
      this.btnInformeX.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnInformeX.Location = new Point(22, 63);
      this.btnInformeX.Name = "btnInformeX";
      this.btnInformeX.Size = new Size(342, 23);
      this.btnInformeX.TabIndex = 2;
      this.btnInformeX.Text = "INFORME X";
      this.btnInformeX.UseVisualStyleBackColor = true;
      this.btnInformeX.Click += new EventHandler(this.btnInformeX_Click);
      this.btnZSegunFecha.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnZSegunFecha.Location = new Point(21, 69);
      this.btnZSegunFecha.Name = "btnZSegunFecha";
      this.btnZSegunFecha.Size = new Size(333, 23);
      this.btnZSegunFecha.TabIndex = 3;
      this.btnZSegunFecha.Text = "Informe Z, Según Rango de Fecha";
      this.btnZSegunFecha.UseVisualStyleBackColor = true;
      this.btnZSegunFecha.Click += new EventHandler(this.btnZSegunFecha_Click);
      this.groupBox1.Controls.Add((Control) this.btnTransaccionSegunFecha);
      this.groupBox1.Controls.Add((Control) this.label2);
      this.groupBox1.Controls.Add((Control) this.label1);
      this.groupBox1.Controls.Add((Control) this.dtpHasta);
      this.groupBox1.Controls.Add((Control) this.dtpDesde);
      this.groupBox1.Controls.Add((Control) this.btnZSegunFecha);
      this.groupBox1.Location = new Point(8, 9);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(371, 152);
      this.groupBox1.TabIndex = 4;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Informes Según Fecha";
      this.btnTransaccionSegunFecha.Location = new Point(21, 109);
      this.btnTransaccionSegunFecha.Name = "btnTransaccionSegunFecha";
      this.btnTransaccionSegunFecha.Size = new Size(333, 23);
      this.btnTransaccionSegunFecha.TabIndex = 8;
      this.btnTransaccionSegunFecha.Text = "Informe de Transacciones (X), Según Rango de Fecha";
      this.btnTransaccionSegunFecha.UseVisualStyleBackColor = true;
      this.btnTransaccionSegunFecha.Click += new EventHandler(this.button1_Click);
      this.label2.AutoSize = true;
      this.label2.Location = new Point(155, 17);
      this.label2.Name = "label2";
      this.label2.Size = new Size(35, 13);
      this.label2.TabIndex = 7;
      this.label2.Text = "Hasta";
      this.label1.AutoSize = true;
      this.label1.Location = new Point(20, 17);
      this.label1.Name = "label1";
      this.label1.Size = new Size(38, 13);
      this.label1.TabIndex = 6;
      this.label1.Text = "Desde";
      this.dtpHasta.Format = DateTimePickerFormat.Short;
      this.dtpHasta.Location = new Point(155, 33);
      this.dtpHasta.Name = "dtpHasta";
      this.dtpHasta.Size = new Size(103, 20);
      this.dtpHasta.TabIndex = 5;
      this.dtpDesde.Format = DateTimePickerFormat.Short;
      this.dtpDesde.Location = new Point(20, 33);
      this.dtpDesde.Name = "dtpDesde";
      this.dtpDesde.Size = new Size(103, 20);
      this.dtpDesde.TabIndex = 4;
      this.groupBox2.Controls.Add((Control) this.btnCierreJornada);
      this.groupBox2.Controls.Add((Control) this.btnInformeX);
      this.groupBox2.Location = new Point(12, 12);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new Size(387, 100);
      this.groupBox2.TabIndex = 5;
      this.groupBox2.TabStop = false;
      this.groupBox3.Controls.Add((Control) this.btnTransaccionSegunNumero);
      this.groupBox3.Controls.Add((Control) this.btnZSegunNumero);
      this.groupBox3.Controls.Add((Control) this.label3);
      this.groupBox3.Controls.Add((Control) this.label4);
      this.groupBox3.Controls.Add((Control) this.txtHasta);
      this.groupBox3.Controls.Add((Control) this.txtDesde);
      this.groupBox3.Location = new Point(12, 395);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new Size(387, (int) sbyte.MaxValue);
      this.groupBox3.TabIndex = 6;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Informes Según Numeros";
      this.groupBox3.Visible = false;
      this.btnTransaccionSegunNumero.Location = new Point(22, 105);
      this.btnTransaccionSegunNumero.Name = "btnTransaccionSegunNumero";
      this.btnTransaccionSegunNumero.Size = new Size(342, 23);
      this.btnTransaccionSegunNumero.TabIndex = 11;
      this.btnTransaccionSegunNumero.Text = "Informe de Transacciones, Según rango de Numero de Transaccion";
      this.btnTransaccionSegunNumero.UseVisualStyleBackColor = true;
      this.btnZSegunNumero.Location = new Point(22, 68);
      this.btnZSegunNumero.Name = "btnZSegunNumero";
      this.btnZSegunNumero.Size = new Size(342, 23);
      this.btnZSegunNumero.TabIndex = 10;
      this.btnZSegunNumero.Text = "Informe Z, Según rango de Números de Z";
      this.btnZSegunNumero.UseVisualStyleBackColor = true;
      this.btnZSegunNumero.Click += new EventHandler(this.btnZSegunNumero_Click);
      this.label3.AutoSize = true;
      this.label3.Location = new Point(155, 20);
      this.label3.Name = "label3";
      this.label3.Size = new Size(35, 13);
      this.label3.TabIndex = 9;
      this.label3.Text = "Hasta";
      this.label4.AutoSize = true;
      this.label4.Location = new Point(20, 20);
      this.label4.Name = "label4";
      this.label4.Size = new Size(38, 13);
      this.label4.TabIndex = 8;
      this.label4.Text = "Desde";
      this.txtHasta.Location = new Point(155, 36);
      this.txtHasta.Name = "txtHasta";
      this.txtHasta.Size = new Size(100, 20);
      this.txtHasta.TabIndex = 1;
      this.txtHasta.KeyPress += new KeyPressEventHandler(this.txtHasta_KeyPress);
      this.txtDesde.Location = new Point(20, 36);
      this.txtDesde.Name = "txtDesde";
      this.txtDesde.Size = new Size(100, 20);
      this.txtDesde.TabIndex = 0;
      this.txtDesde.KeyPress += new KeyPressEventHandler(this.txtDesde_KeyPress);
      this.btnCambiarHora.Location = new Point(309, 294);
      this.btnCambiarHora.Name = "btnCambiarHora";
      this.btnCambiarHora.Size = new Size(91, 37);
      this.btnCambiarHora.TabIndex = 7;
      this.btnCambiarHora.Text = "Abrir Cajon";
      this.btnCambiarHora.UseVisualStyleBackColor = true;
      this.btnCambiarHora.Click += new EventHandler(this.btnCambiarHora_Click);
      this.panel1.BorderStyle = BorderStyle.Fixed3D;
      this.panel1.Controls.Add((Control) this.groupBox1);
      this.panel1.Location = new Point(12, 117);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(387, 172);
      this.panel1.TabIndex = 8;
      this.btnDesbloquearImpresora.Location = new Point(12, 294);
      this.btnDesbloquearImpresora.Name = "btnDesbloquearImpresora";
      this.btnDesbloquearImpresora.Size = new Size(91, 37);
      this.btnDesbloquearImpresora.TabIndex = 10;
      this.btnDesbloquearImpresora.Text = "Desbloquear Impresora";
      this.btnDesbloquearImpresora.UseVisualStyleBackColor = true;
      this.btnDesbloquearImpresora.Visible = false;
      this.btnDesbloquearImpresora.Click += new EventHandler(this.btnDesbloquearImpresora_Click);
      this.button1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button1.Location = new Point(208, 294);
      this.button1.Name = "button1";
      this.button1.Size = new Size(93, 37);
      this.button1.TabIndex = 11;
      this.button1.Text = "Estado Impresora Fiscal";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click_1);
      this.btnHorasJornada.Location = new Point(111, 294);
      this.btnHorasJornada.Name = "btnHorasJornada";
      this.btnHorasJornada.Size = new Size(91, 37);
      this.btnHorasJornada.TabIndex = 12;
      this.btnHorasJornada.Text = "Hrs Jornada Fiscal";
      this.btnHorasJornada.UseVisualStyleBackColor = true;
      this.btnHorasJornada.Click += new EventHandler(this.btnHorasJornada_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
//      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(223, 233, 245);
      this.ClientSize = new Size(412, 337);
      this.Controls.Add((Control) this.btnHorasJornada);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.btnDesbloquearImpresora);
      this.Controls.Add((Control) this.panel1);
      this.Controls.Add((Control) this.groupBox3);
      this.Controls.Add((Control) this.btnCambiarHora);
      this.Controls.Add((Control) this.groupBox2);
      this.Controls.Add((Control) this.ocxFiscal);
//      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.Name = "frmModuloFiscal";
      this.ShowIcon = false;
      this.Text = "Modulo Fiscal";
      this.KeyDown += new KeyEventHandler(this.frmModuloFiscal_KeyDown);
      ((ISupportInitialize) this.ocxFiscal).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    private void estadoImpresora()
    {
      string str = new LeeXml().leeEstadoImpresoraFiscal();
      if (!str.Substring(0, 1).Equals("4"))
        return;
      int length = str.Length - 2;
      int num = (int) MessageBox.Show("La Boleta Folio: " + str.Substring(2, length) + " No se Imprimio Correctamente, Se abrira el Modulo de Boleta y terminara de Imprimir", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      new frmBoletaFiscal().Show();
    }

    public void cargaOpcionesDocumentos()
    {
      OpcionesGenerales opcionesGenerales = new OpcionesGenerales();
      OpcionesDocumentosVO opcionesDocumentosVo = new OpcionesDocumentosVO();
      opcionesDocumentosVo = opcionesGenerales.rescataOpcionesDocumentosPorNombre("BOLETA");
      this._puertoImpresoraFiscal = new OpcionesGenerales().puertoFiscal();
    }

    private void soloNumeros(KeyPressEventArgs e, TextBox caja)
    {
      if (caja.Text.Trim().Length == 0 && (int) e.KeyChar == 44)
        e.KeyChar = '0';
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
        else
          e.Handled = true;
      }
    }

    private void btnCierreJornada_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Esta Seguro de Cerrar La Jornada Fiscal en Curso ", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
      {
        this.val = this.ocxFiscal.init(this._puertoImpresoraFiscal);
        if (this.val == 1)
        {
          this.val = this.ocxFiscal.cierrejornada();
          try
          {
            this.ocxFiscal.obtenerdatosfiscal();
            new ControlFiscal().guardaZ(this.ocxFiscal.caja.ToString());
          }
          catch (Exception ex)
          {
            int num = (int) MessageBox.Show("Error al guarda Cierre Z: " + ex.Message);
          }
          this.val = this.ocxFiscal.fini();
        }
        else
        {
          int num1 = (int) MessageBox.Show("No Hay Conexion con Impresora " + this.val.ToString(), "Error de Conexion", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
      }
      else
      {
        int num2 = (int) MessageBox.Show("La Jornada Fiscal No fue Cerrada ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
    }

    private void btnInformeX_Click(object sender, EventArgs e)
    {
      this.val = this.ocxFiscal.init(this._puertoImpresoraFiscal);
      if (this.val == 1)
      {
        this.val = this.ocxFiscal.informeX();
        this.val = this.ocxFiscal.fini();
      }
      else
      {
        int num = (int) MessageBox.Show("No Hay Conexion con Impresora " + this.val.ToString(), "Error de Conexion", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void btnZSegunFecha_Click(object sender, EventArgs e)
    {
      string str1 = this.dtpDesde.Value.ToString("yyyyMMdd") + "000000";
      string str2 = this.dtpHasta.Value.ToString("yyyyMMdd") + "235959";
      this.val = this.ocxFiscal.init(this._puertoImpresoraFiscal);
      if (this.val == 1)
      {
        this.val = this.ocxFiscal.informeZfecha(str1, str2, (short) 1, "");
        this.val = this.ocxFiscal.fini();
      }
      else
      {
        int num = (int) MessageBox.Show("No Hay Conexion con Impresora " + this.val.ToString(), "Error de Conexion", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      string str1 = this.dtpDesde.Value.ToString("yyyyMMdd") + "000000";
      string str2 = this.dtpHasta.Value.ToString("yyyyMMdd") + "235959";
      this.val = this.ocxFiscal.init(this._puertoImpresoraFiscal);
      if (this.val == 1)
      {
        this.val = this.ocxFiscal.informeTransfecha(str1, str2, (short) 1, "");
        this.val = this.ocxFiscal.fini();
      }
      else
      {
        int num = (int) MessageBox.Show("No Hay Conexion con Impresora " + this.val.ToString(), "Error de Conexion", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void btnZSegunNumero_Click(object sender, EventArgs e)
    {
      if (this.txtDesde.Text.Trim().Length > 0 && this.txtHasta.Text.Trim().Length > 0)
      {
        int num1 = Convert.ToInt32(this.txtDesde.Text.Trim());
        int num2 = Convert.ToInt32(this.txtHasta.Text.Trim());
        if (num1 <= num2)
        {
          this.val = this.ocxFiscal.init(this._puertoImpresoraFiscal);
          if (this.val == 1)
          {
            this.val = this.ocxFiscal.informeZno(num1, num2, (short) 1, "");
            this.val = this.ocxFiscal.fini();
          }
          else
          {
            int num3 = (int) MessageBox.Show("No Hay Conexion con Impresora " + this.val.ToString(), "Error de Conexion", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          }
        }
        else
        {
          int num3 = (int) MessageBox.Show("El Numero DESDE debe ser menor al Numero de HASTA");
          this.txtDesde.Focus();
        }
      }
      else
      {
        int num = (int) MessageBox.Show("Debe Ingresar Valores DESDE y HASTA");
        this.txtDesde.Focus();
      }
    }

    private void txtDesde_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtDesde);
    }

    private void txtHasta_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtHasta);
    }

    private void btnCambiarHora_Click(object sender, EventArgs e)
    {
      this.val = this.ocxFiscal.init(this._puertoImpresoraFiscal);
      if (this.val == 1)
      {
        this.val = this.ocxFiscal.abrircajon();
        this.val = this.ocxFiscal.fini();
      }
      else
      {
        int num = (int) MessageBox.Show("No Hay Conexion con Impresora " + this.val.ToString(), "Error de Conexion", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void btnDesbloquearImpresora_Click(object sender, EventArgs e)
    {
      int num1 = 0;
      if (this.ocxFiscal.init(this._puertoImpresoraFiscal) == 1)
      {
        if (this.ocxFiscal.abrirboleta((short) 0, (short) 0) != 4)
          return;
        this.ocxFiscal.agregaitem("PRODUCTO 1", 1f, 1);
        this.ocxFiscal.agregadescuento("Descuento", 0);
        this.ocxFiscal.agregapago((short) 0, 100000);
        this.ocxFiscal.cierraboleta((short) 0);
        this.ocxFiscal.fini();
      }
      else
      {
        num1 = this.ocxFiscal.fini();
        int num2 = (int) MessageBox.Show("No Hay Conexion con Impresora " + this.val.ToString(), "Error de Conexion", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void button1_Click_1(object sender, EventArgs e)
    {
      this.val = this.ocxFiscal.init(this._puertoImpresoraFiscal);
      if (this.val == 1)
      {
        this.val = this.ocxFiscal.obtenerestado();
        this.val = this.ocxFiscal.estado;
        string str;
        if (this.val == 2)
        {
          this.ocxFiscal.obtenerdatosfiscal();
          str = "Jornada Fiscal Abierta " + new ControlFiscal().ultimaZSinCOntrolFiscal(this.ocxFiscal.caja.ToString()).ToString("N2") + " HRS.";
        }
        else if (this.val == 1)
          str = "Jornada Fiscal Cerrada";
        else if (this.val == 5)
        {
          str = "Boleta fiscal Abierta, Esperando productos, pulse boton Desbloquear";
          this.btnDesbloquearImpresora.Visible = true;
        }
        else if (this.val == 6)
        {
          str = "Boleta fiscal Abierta, Esperando Pagos";
          this.ocxFiscal.agregapago((short) 0, 10000000);
          this.ocxFiscal.cierraboleta((short) 0);
        }
        else
          str = "No Hay Respuesta de Impresora, verifique que se encuentre Encendida";
        int num = (int) MessageBox.Show("Estado " + this.val.ToString() + " " + str, "Estado Fiscal", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.val = this.ocxFiscal.fini();
      }
      else
      {
        int num1 = (int) MessageBox.Show("No Hay Conexion con Impresora " + this.val.ToString(), "Error de Conexion", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void frmModuloFiscal_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.F10)
        return;
      this.btnDesbloquearImpresora.Visible = true;
    }

    private void btnHorasJornada_Click(object sender, EventArgs e)
    {
      this.val = this.ocxFiscal.init(this._puertoImpresoraFiscal);
      if (this.val == 1)
      {
        this.val = this.ocxFiscal.obtenerestado();
        this.val = this.ocxFiscal.estado;
        if (this.val == 2)
        {
          try
          {
            this.ocxFiscal.obtenerdatosfiscal();
            int num = (int) MessageBox.Show("JORNADA FISCAL : " + new ControlFiscal().ultimaZSinCOntrolFiscal(this.ocxFiscal.caja.ToString()).ToString("N2") + " HRS.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          }
          catch (Exception ex)
          {
            int num = (int) MessageBox.Show("Error: " + ex.Message);
          }
        }
        else if (this.val == 1)
        {
          int num1 = (int) MessageBox.Show("LA JORNADA FISCAL SE ENCUENTRA CERRADA", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        else
        {
          int num2 = (int) MessageBox.Show("No Hay Respuesta de Impresora, verifique que se encuentre Encendida", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        this.val = this.ocxFiscal.fini();
      }
      else
      {
        int num3 = (int) MessageBox.Show("No Hay Conexion con Impresora " + this.val.ToString(), "Error de Conexion", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }
  }
}
