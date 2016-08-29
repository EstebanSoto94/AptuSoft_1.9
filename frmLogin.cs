
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Management;
using System.Windows.Forms;

namespace Aptusoft
{
  public class frmLogin : Form
  {
    private string _empresaPredeterminada = "";
    private bool _multiempresa = true;
    private IContainer components = (IContainer) null;
    public static string _Empresa;
    private Label label1;
    private Label label2;
    private TextBox txtNombre;
    private TextBox txtClave;
    private Button btnIngresar;
    private Label lblConexion;
    private Label lblInfoPc;
    private Panel pnlContraclave;
    private Button btnRegistrar;
    private TextBox txtContraclave;
    private Label lblSerie;
    private Label label3;
    private Label lblEmpresa;
    private Panel panelMultiempresa;
    private ComboBox cmbConexiones;
    private PictureBox pictureBox1;
    private Label label4;

    public frmLogin()
    {
        if (!File.Exists(@"C:\Aptusoft\xml\config.xml"))
        {
            respaldo_xml_config rp = new respaldo_xml_config();
            rp.recupera();
        }
            try
            {
                this.InitializeComponent();
                try
                {
                    this.verificaContraclave();
                }
                catch (Exception ex)
                {
                    int num = (int)MessageBox.Show("Error 1 " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                if (this._multiempresa)
                {
                    this.panelMultiempresa.Visible = true;
                    this.listaConexiones();
                }
                else
                    this.panelMultiempresa.Visible = false;
                try
                {
                    this.cargarDatos();
                }
                catch (Exception ex)
                {
                    int num = (int)MessageBox.Show("Error 2 " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show("Error 0 " + ex.Message, "Error 0", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
    

    private void listaConexiones()
    {
      DataSet dataSet = new DataSet("datos");
      int num = (int) dataSet.ReadXml("C:\\AptuSoft\\xml\\config.xml");
      string filterExpression = "principal=1";
      foreach (DataRow dataRow in dataSet.Tables["Conexion"].Select(filterExpression))
        this._empresaPredeterminada = dataRow["empresa"].ToString();
      this.cmbConexiones.DataSource = (object) dataSet.Tables["Conexion"];
      this.cmbConexiones.ValueMember = "empresa";
      this.cmbConexiones.DisplayMember = "empresa";
      this.cmbConexiones.SelectedValue = (object) this._empresaPredeterminada;
    }

    private void btnIngresar_Click(object sender, EventArgs e)
    {
      if (!this.pruebaConexion() || !this.valida())
        return;
      this.login();
    }

    private bool pruebaConexion()
    {
      try
      {
        Conexion.getConecta().cerrarConexion();
        return true;
      }
      catch
      {
        int num = (int) MessageBox.Show("Error al Conectar, Verifique Configuracion de Conexion a Base de Datos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        return false;
      }
    }

    private bool valida()
    {
      if (this.txtNombre.Text.Trim().Length == 0)
      {
        int num = (int) MessageBox.Show("Debe Ingresar Usuario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.txtNombre.Focus();
        return false;
      }
      if (this.txtClave.Text.Trim().Length != 0)
        return true;
      int num1 = (int) MessageBox.Show("Debe Ingresar Contraseña", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      this.txtClave.Focus();
      return false;
    }

    private void login()
    {
      string nombre = this.txtNombre.Text.Trim().ToUpper();
      string clave = this.txtClave.Text.Trim().ToUpper();
      Usuario usuario = new Usuario();
      int idUsuario = usuario.loginUsuario(nombre, clave);
      if (idUsuario == 0)
      {
        int num = (int) MessageBox.Show("Nombre o Contraseña Incorrecto", "Aptusoft", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.txtNombre.Focus();
      }
      else
      {
        try
        {
          new frmMenuPrincipal(this, usuario.loginUsuarioDetalleTipo(idUsuario)).Show();
          this.Hide();
        }
        catch (Exception ex)
        {
          int num = (int) MessageBox.Show("Error al cargar Permisos: " + ex.Message);
        }
      }
    }

    private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
    {
      if ((int) e.KeyChar != 13)
        return;
      e.Handled = false;
      this.txtClave.Focus();
    }

    private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
    {
      if ((int) e.KeyChar != 13)
        return;
      e.Handled = false;
      this.btnIngresar.Focus();
    }

    private void lblInfoPc_DoubleClick(object sender, EventArgs e)
    {
      int num = (int) new frmInfoPc().ShowDialog();
    }

    private void lblConexion_DoubleClick(object sender, EventArgs e)
    {
      if (this._multiempresa)
      {
        int num = (int) new frmConexion().ShowDialog();
        this.cargarDatos();
        this.listaConexiones();
      }
      else
      {
        int num1 = (int) new frmConexionUnaEmpresa().ShowDialog();
      }
    }

    private void muestraId()
    {
      this.lblSerie.Text = this.generaIdCliente(this.sacaLetras(this.GetHDSerial()), this.obtieneUltimosDigitosCpu(this.GetCPUId()));
    }

    public string GetCPUId()
    {
      try
      {
        string str1 = string.Empty;
        string str2 = string.Empty;
        foreach (ManagementObject managementObject in new ManagementClass("Win32_Processor").GetInstances())
        {
          if (str1 == string.Empty)
            str1 = managementObject.Properties["ProcessorId"].Value.ToString();
        }
        return str1;
      }
      catch
      {
        return "178BFBFF00100F62";
      }
    }

    public string GetHDSerial()
    {
      try
      {
        return new ManagementObject("Win32_LogicalDisk.DeviceID=\"C:\"").Properties["VolumeSerialNumber"].Value.ToString();
      }
      catch
      {
        return "4487FEA6";
      }
    }

    private string sacaLetras(string texto)
    {
      string str1 = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ";
      string str2 = "";
      List<Letra> list = new List<Letra>();
      int num = 1;
      for (int index = 0; index < str1.Length; ++index)
      {
        list.Add(new Letra()
        {
          Codigo = num,
          Caracter = str1[index]
        });
        if (num == 9)
          num = 1;
        else
          ++num;
      }
      for (int index = 0; index < texto.Length; ++index)
      {
        string str3 = "";
        foreach (Letra letra in list)
        {
          if ((int) letra.Caracter == (int) texto[index])
            str3 += letra.Codigo.ToString();
        }
        str2 = str3.Length <= 0 ? str2 + texto[index].ToString() : str2 + str3;
      }
      return str2;
    }

    private string obtieneUltimosDigitosCpu(string cpu)
    {
      string str1 = this.sacaLetras(cpu);
      char ch = str1[str1.Length - 2];
      string str2 = ch.ToString();
      ch = str1[str1.Length - 1];
      string str3 = ch.ToString();
      return str2 + str3;
    }

    private string generaIdCliente(string idDis, string idCpu)
    {
      Decimal num = new Decimal(0);
      return Math.Round((Decimal) Convert.ToInt64(idDis) * new Decimal(1312) / (Decimal) Convert.ToInt64(idCpu), MidpointRounding.AwayFromZero).ToString() + idCpu;
    }

    private string inv(string text1)
    {
        string str = "";
        int index1 = text1.Length - 1;
        for (int index2 = 0; index2 < text1.Length; ++index2)
        {
            string rj = Convert.ToString(text1[index1]);
            str += rj;
            --index1;
        }
        return str;
           
    }

    private void registraContraclave()
    {
      DataSet dataSet = new DataSet();
      int num1 = (int) dataSet.ReadXml("C:\\AptuSoft\\xml\\config.xml");
      dataSet.Tables["Registro"].Rows[0]["contraclave"] = (object) this.txtContraclave.Text.Trim();
      dataSet.WriteXml("C:\\AptuSoft\\xml\\config.xml");
      int num2 = (int) MessageBox.Show("SISTEMA REGISTRADO CORRECTAMENTE", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      respaldo_xml_config rp = new respaldo_xml_config();
      rp.genera_backup();
      this.pnlContraclave.Visible = false;
    }

    private void verificaContraclave()
    {
      DataSet dataSet = new DataSet();
      int num = (int) dataSet.ReadXml("C:\\AptuSoft\\xml\\config.xml");
      if (this.inv(dataSet.Tables["Registro"].Rows[0]["contraclave"].ToString()).Equals((Convert.ToInt64(this.sacaLetras(this.GetHDSerial())) * 33L).ToString()))
        this.pnlContraclave.Visible = false;
      else
        this.muestraId();
    }
      //generador de contraclave
    private void btnRegistrar_Click_1(object sender, EventArgs e)
    {
      if (this.inv(this.txtContraclave.Text).Equals((Convert.ToInt64(this.sacaLetras(this.GetHDSerial())) * 33L).ToString()))
      {
        this.registraContraclave();
      }
      else
      {
        int num = (int) MessageBox.Show("LA CONTRACLAVE NO ES CORRECTA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void lblConexion_Click(object sender, EventArgs e)
    {
    }

    private void cargarDatos()
    {
      try
      {
        DataSet dataSet = new DataSet();
        int num = (int) dataSet.ReadXml("C:\\AptuSoft\\xml\\config.xml");
        string filterExpression = "principal=1";
        foreach (DataRow dataRow in dataSet.Tables["conexion"].Select(filterExpression))
          frmLogin._Empresa = dataRow["empresa"].ToString();
        this.lblEmpresa.Text = "Conectado a " + frmLogin._Empresa;
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error " + ex.Message);
      }
    }

    private void cmbConexiones_SelectedValueChanged(object sender, EventArgs e)
    {
      if (!(this.cmbConexiones.Text != "System.Data.DataRowView"))
        return;
      this.cambiaConexion(this.cmbConexiones.Text);
      this.cargarDatos();
    }

    private void cambiaConexion(string empresa)
    {
      DataSet dataSet = new DataSet("datos");
      int num = (int) dataSet.ReadXml("C:\\AptuSoft\\xml\\config.xml");
      string filterExpression1 = "principal='1'";
      DataRow[] dataRowArray1 = dataSet.Tables["Conexion"].Select(filterExpression1);
      for (int index = 0; index < dataRowArray1.Length; ++index)
        dataRowArray1[0]["principal"] = (object) "0";
      string filterExpression2 = "empresa='" + empresa + "'";
      DataRow[] dataRowArray2 = dataSet.Tables["Conexion"].Select(filterExpression2);
      for (int index = 0; index < dataRowArray2.Length; ++index)
        dataRowArray2[0]["principal"] = (object) "1";
      dataSet.WriteXml("C:\\AptuSoft\\xml\\config.xml");
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblConexion = new System.Windows.Forms.Label();
            this.lblInfoPc = new System.Windows.Forms.Label();
            this.pnlContraclave = new System.Windows.Forms.Panel();
            this.lblSerie = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtContraclave = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.panelMultiempresa = new System.Windows.Forms.Panel();
            this.cmbConexiones = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlContraclave.SuspendLayout();
            this.panelMultiempresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "USUARIO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "CONTRASEÑA";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(117, 194);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(142, 26);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtClave
            // 
            this.txtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.Location = new System.Drawing.Point(117, 226);
            this.txtClave.MaxLength = 50;
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(142, 26);
            this.txtClave.TabIndex = 3;
            this.txtClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClave_KeyPress);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnIngresar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.Location = new System.Drawing.Point(117, 256);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(143, 36);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "INGRESAR";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblConexion
            // 
            this.lblConexion.AutoSize = true;
            this.lblConexion.BackColor = System.Drawing.Color.Transparent;
            this.lblConexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConexion.ForeColor = System.Drawing.Color.White;
            this.lblConexion.Location = new System.Drawing.Point(4, 377);
            this.lblConexion.Name = "lblConexion";
            this.lblConexion.Size = new System.Drawing.Size(67, 15);
            this.lblConexion.TabIndex = 6;
            this.lblConexion.Text = "Conexion";
            this.lblConexion.Click += new System.EventHandler(this.lblConexion_Click);
            this.lblConexion.DoubleClick += new System.EventHandler(this.lblConexion_DoubleClick);
            // 
            // lblInfoPc
            // 
            this.lblInfoPc.AutoSize = true;
            this.lblInfoPc.BackColor = System.Drawing.Color.Transparent;
            this.lblInfoPc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoPc.ForeColor = System.Drawing.Color.White;
            this.lblInfoPc.Location = new System.Drawing.Point(256, 9);
            this.lblInfoPc.Name = "lblInfoPc";
            this.lblInfoPc.Size = new System.Drawing.Size(19, 15);
            this.lblInfoPc.TabIndex = 7;
            this.lblInfoPc.Text = "[.]";
            this.lblInfoPc.DoubleClick += new System.EventHandler(this.lblInfoPc_DoubleClick);
            // 
            // pnlContraclave
            // 
            this.pnlContraclave.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnlContraclave.Controls.Add(this.lblSerie);
            this.pnlContraclave.Controls.Add(this.btnRegistrar);
            this.pnlContraclave.Controls.Add(this.txtContraclave);
            this.pnlContraclave.Controls.Add(this.label3);
            this.pnlContraclave.Location = new System.Drawing.Point(2, 158);
            this.pnlContraclave.Name = "pnlContraclave";
            this.pnlContraclave.Size = new System.Drawing.Size(273, 212);
            this.pnlContraclave.TabIndex = 8;
            // 
            // lblSerie
            // 
            this.lblSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerie.ForeColor = System.Drawing.Color.Yellow;
            this.lblSerie.Location = new System.Drawing.Point(12, 77);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(249, 20);
            this.lblSerie.TabIndex = 5;
            this.lblSerie.Text = "serie";
            this.lblSerie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(99, 174);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 7;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click_1);
            // 
            // txtContraclave
            // 
            this.txtContraclave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraclave.Location = new System.Drawing.Point(14, 122);
            this.txtContraclave.Name = "txtContraclave";
            this.txtContraclave.Size = new System.Drawing.Size(245, 26);
            this.txtContraclave.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Registro de Sistema AptuSoft";
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.ForeColor = System.Drawing.Color.White;
            this.lblEmpresa.Location = new System.Drawing.Point(7, 9);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(11, 15);
            this.lblEmpresa.TabIndex = 9;
            this.lblEmpresa.Text = ".";
            // 
            // panelMultiempresa
            // 
            this.panelMultiempresa.BackColor = System.Drawing.Color.Transparent;
            this.panelMultiempresa.Controls.Add(this.cmbConexiones);
            this.panelMultiempresa.Controls.Add(this.label4);
            this.panelMultiempresa.Location = new System.Drawing.Point(13, 320);
            this.panelMultiempresa.Name = "panelMultiempresa";
            this.panelMultiempresa.Size = new System.Drawing.Size(247, 53);
            this.panelMultiempresa.TabIndex = 10;
            // 
            // cmbConexiones
            // 
            this.cmbConexiones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConexiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbConexiones.FormattingEnabled = true;
            this.cmbConexiones.Location = new System.Drawing.Point(92, 13);
            this.cmbConexiones.Name = "cmbConexiones";
            this.cmbConexiones.Size = new System.Drawing.Size(143, 28);
            this.cmbConexiones.TabIndex = 11;
            this.cmbConexiones.SelectedValueChanged += new System.EventHandler(this.cmbConexiones_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 26);
            this.label4.TabIndex = 11;
            this.label4.Text = "EMPRESA";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(6, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 145);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(162)))), ((int)(((byte)(140)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(277, 397);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlContraclave);
            this.Controls.Add(this.panelMultiempresa);
            this.Controls.Add(this.lblEmpresa);
            this.Controls.Add(this.lblInfoPc);
            this.Controls.Add(this.lblConexion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema AptuSoft";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.pnlContraclave.ResumeLayout(false);
            this.pnlContraclave.PerformLayout();
            this.panelMultiempresa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }
    public void reboot()
    {
        Application.Restart();
    }
    private void frmLogin_Load(object sender, EventArgs e)
    {
        
    }
  }
}
