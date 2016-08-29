 
// Type: Aptusoft.frmConexionUnaEmpresa
 
 
// version 1.8.0

using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Aptusoft
{
  public class frmConexionUnaEmpresa : Form
  {
    private IContainer components = (IContainer) null;
    private DataSet dsDatosXml = new DataSet("datos");
    private string _empresa = "";
    private TextBox txtPass;
    private TextBox txtUsuario;
    private TextBox txtBase;
    private TextBox txtServidor;
    private Label label4;
    private Label label3;
    private Label label2;
    private Label label1;
    private Button btnGuardar;
    private Label lblMuestraTexto;

    public frmConexionUnaEmpresa()
    {
      this.InitializeComponent();
      this.cargarDatos();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.txtPass = new TextBox();
      this.txtUsuario = new TextBox();
      this.txtBase = new TextBox();
      this.txtServidor = new TextBox();
      this.label4 = new Label();
      this.label3 = new Label();
      this.label2 = new Label();
      this.label1 = new Label();
      this.btnGuardar = new Button();
      this.lblMuestraTexto = new Label();
      this.SuspendLayout();
      this.txtPass.Location = new Point(87, 88);
      this.txtPass.Name = "txtPass";
      this.txtPass.Size = new Size(185, 20);
      this.txtPass.TabIndex = 20;
      this.txtPass.UseSystemPasswordChar = true;
      this.txtUsuario.Location = new Point(87, 64);
      this.txtUsuario.Name = "txtUsuario";
      this.txtUsuario.Size = new Size(185, 20);
      this.txtUsuario.TabIndex = 19;
      this.txtUsuario.UseSystemPasswordChar = true;
      this.txtBase.Location = new Point(87, 40);
      this.txtBase.Name = "txtBase";
      this.txtBase.Size = new Size(185, 20);
      this.txtBase.TabIndex = 18;
      this.txtBase.UseSystemPasswordChar = true;
      this.txtServidor.Location = new Point(87, 16);
      this.txtServidor.Name = "txtServidor";
      this.txtServidor.Size = new Size(185, 20);
      this.txtServidor.TabIndex = 15;
      this.txtServidor.UseSystemPasswordChar = true;
      this.label4.AutoSize = true;
      this.label4.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label4.ForeColor = Color.Black;
      this.label4.Location = new Point(20, 94);
      this.label4.Name = "label4";
      this.label4.Size = new Size(61, 13);
      this.label4.TabIndex = 17;
      this.label4.Text = "Contraseña";
      this.label3.AutoSize = true;
      this.label3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label3.ForeColor = Color.Black;
      this.label3.Location = new Point(38, 69);
      this.label3.Name = "label3";
      this.label3.Size = new Size(43, 13);
      this.label3.TabIndex = 16;
      this.label3.Text = "Usuario";
      this.label2.AutoSize = true;
      this.label2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label2.ForeColor = Color.Black;
      this.label2.Location = new Point(4, 44);
      this.label2.Name = "label2";
      this.label2.Size = new Size(77, 13);
      this.label2.TabIndex = 13;
      this.label2.Text = "Base de Datos";
      this.label1.AutoSize = true;
      this.label1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label1.ForeColor = Color.Black;
      this.label1.Location = new Point(35, 19);
      this.label1.Name = "label1";
      this.label1.Size = new Size(46, 13);
      this.label1.TabIndex = 12;
      this.label1.Text = "Servidor";
      this.btnGuardar.BackColor = Color.FromArgb(223, 233, 245);
      this.btnGuardar.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnGuardar.Location = new Point(295, 17);
      this.btnGuardar.Name = "btnGuardar";
      this.btnGuardar.Size = new Size(115, 47);
      this.btnGuardar.TabIndex = 22;
      this.btnGuardar.Text = "Guardar y Probar Conexión";
      this.btnGuardar.UseVisualStyleBackColor = true;
      this.btnGuardar.Click += new EventHandler(this.btnGuardar_Click);
      this.lblMuestraTexto.Location = new Point(378, 103);
      this.lblMuestraTexto.Name = "lblMuestraTexto";
      this.lblMuestraTexto.Size = new Size(46, 23);
      this.lblMuestraTexto.TabIndex = 23;
      this.lblMuestraTexto.Click += new EventHandler(this.lblMuestraTexto_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
//      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(223, 233, 245);
      this.ClientSize = new Size(422, 124);
      this.Controls.Add((Control) this.lblMuestraTexto);
      this.Controls.Add((Control) this.btnGuardar);
      this.Controls.Add((Control) this.txtPass);
      this.Controls.Add((Control) this.txtUsuario);
      this.Controls.Add((Control) this.txtBase);
      this.Controls.Add((Control) this.txtServidor);
      this.Controls.Add((Control) this.label4);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
//      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Name = "frmConexionUnaEmpresa";
      this.ShowIcon = false;
      this.Text = "Datos de Conexion";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private void iniciaFormulario()
    {
      this.txtBase.Clear();
      this.txtUsuario.Clear();
      this.txtPass.Clear();
      this.txtServidor.Clear();
      this.dsDatosXml = new DataSet("datos");
      this.btnGuardar.Enabled = true;
      this._empresa = "";
    }

    private void cargarDatos()
    {
      try
      {
        this.iniciaFormulario();
        int num = (int) this.dsDatosXml.ReadXml("C:\\AptuSoft\\xml\\config.xml");
        this.txtServidor.Text = this.dsDatosXml.Tables["Conexion"].Rows[0]["server"].ToString();
        this.txtBase.Text = this.dsDatosXml.Tables["Conexion"].Rows[0]["base"].ToString();
        this.txtUsuario.Text = this.dsDatosXml.Tables["Conexion"].Rows[0]["user"].ToString();
        this.txtPass.Text = this.dsDatosXml.Tables["Conexion"].Rows[0]["pass"].ToString();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("No hay registros, Ingrese Datos " + ex.Message);
      }
    }

    private bool pruebaConexion()
    {
      try
      {
        Conexion conexion = Conexion.pruebaConexion(this.txtServidor.Text.Trim(), this.txtBase.Text.Trim(), this.txtUsuario.Text.Trim(), this.txtPass.Text.Trim());
        int num = (int) MessageBox.Show("Conexión Bien Establecida", "Conexión", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        conexion.cerrarConexion();
        return true;
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al Conectar " + ex.Message, "Conexión Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        return false;
      }
    }

    private bool valida()
    {
      if (this.txtServidor.Text.Trim().Length == 0)
      {
        int num = (int) MessageBox.Show("Ingrese Servidor");
        this.txtServidor.Focus();
        return false;
      }
      if (this.txtUsuario.Text.Trim().Length == 0)
      {
        int num = (int) MessageBox.Show("Ingrese Usuario");
        this.txtUsuario.Focus();
        return false;
      }
      if (this.txtBase.Text.Trim().Length == 0)
      {
        int num = (int) MessageBox.Show("Ingrese Base de datos");
        this.txtBase.Focus();
        return false;
      }
      if (this.txtPass.Text.Trim().Length != 0)
        return true;
      int num1 = (int) MessageBox.Show("Ingrese password");
      this.txtPass.Focus();
      return false;
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
      if (!this.valida() || !this.pruebaConexion())
        return;
      DataSet dataSet = new DataSet();
      int num = (int) dataSet.ReadXml("C:\\AptuSoft\\xml\\config.xml");
      dataSet.Tables["Conexion"].Rows[0]["server"] = (object) this.txtServidor.Text.Trim();
      dataSet.Tables["Conexion"].Rows[0]["base"] = (object) this.txtBase.Text.Trim();
      dataSet.Tables["Conexion"].Rows[0]["user"] = (object) this.txtUsuario.Text.Trim();
      dataSet.Tables["Conexion"].Rows[0]["pass"] = (object) this.txtPass.Text.Trim();
      dataSet.WriteXml("C:\\AptuSoft\\xml\\config.xml");
      this.Close();
    }

    private void lblMuestraTexto_Click(object sender, EventArgs e)
    {
      this.txtServidor.UseSystemPasswordChar = !this.txtServidor.UseSystemPasswordChar;
      this.txtUsuario.UseSystemPasswordChar = !this.txtUsuario.UseSystemPasswordChar;
      this.txtBase.UseSystemPasswordChar = !this.txtBase.UseSystemPasswordChar;
      this.txtPass.UseSystemPasswordChar = !this.txtPass.UseSystemPasswordChar;
      this.Refresh();
    }
  }
}
