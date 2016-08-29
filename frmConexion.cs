
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace Aptusoft
{
  public class frmConexion : Form
  {
    private DataSet dsDatosXml = new DataSet("datos");
    private string _empresa = "";
    private IContainer components = (IContainer) null;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private TextBox txtServidor;
    private TextBox txtBase;
    private TextBox txtUsuario;
    private TextBox txtPass;
    private Button btnGuardar;
    private DataGridView dgvDatos;
    private TextBox txtEmpresa;
    private Label label5;
    private CheckBox chkPredeterminada;
    private Button btnEliminar;
    private Button btnModificar;
    private Button btnLimpiar;
    private Label lblMuestraTexto;

    public frmConexion()
    {
      this.InitializeComponent();
      this.cargarDatos();
    }

    private void iniciaFormulario()
    {
      this.txtEmpresa.Clear();
      this.txtBase.Clear();
      this.txtUsuario.Clear();
      this.txtPass.Clear();
      this.txtServidor.Clear();
      this.chkPredeterminada.Checked = false;
      this.dgvDatos.DataSource = (object) null;
      this.dgvDatos.Columns.Clear();
      this.creaColumnasDetalle();
      this.dsDatosXml = new DataSet("datos");
      this.txtEmpresa.Focus();
      this.btnEliminar.Enabled = false;
      this.btnModificar.Enabled = false;
      this.btnGuardar.Enabled = true;
      this._empresa = "";
    }

    private void creaColumnasDetalle()
    {
      this.dgvDatos.AutoGenerateColumns = false;
      this.dgvDatos.Columns.Add("Linea", "");
      this.dgvDatos.Columns[0].DataPropertyName = "Linea";
      this.dgvDatos.Columns[0].Width = 20;
      this.dgvDatos.Columns[0].Resizable = DataGridViewTriState.False;
      this.dgvDatos.Columns[0].DefaultCellStyle.BackColor = Color.DarkGray;
      this.dgvDatos.Columns[0].Visible = false;
      this.dgvDatos.Columns.Add("empresa", "Empresa");
      this.dgvDatos.Columns[1].DataPropertyName = "empresa";
      this.dgvDatos.Columns[1].Width = 300;
      this.dgvDatos.Columns[1].Resizable = DataGridViewTriState.False;
      this.dgvDatos.Columns.Add("server", "Server");
      this.dgvDatos.Columns[2].DataPropertyName = "server";
      this.dgvDatos.Columns[2].Width = 100;
      this.dgvDatos.Columns[2].Resizable = DataGridViewTriState.False;
      this.dgvDatos.Columns[2].Visible = false;
      this.dgvDatos.Columns.Add("base", "Base");
      this.dgvDatos.Columns[3].DataPropertyName = "base";
      this.dgvDatos.Columns[3].Width = 100;
      this.dgvDatos.Columns[3].Resizable = DataGridViewTriState.False;
      this.dgvDatos.Columns[3].Visible = false;
      this.dgvDatos.Columns.Add("user", "User");
      this.dgvDatos.Columns[4].DataPropertyName = "user";
      this.dgvDatos.Columns[4].Width = 100;
      this.dgvDatos.Columns[4].Resizable = DataGridViewTriState.False;
      this.dgvDatos.Columns[4].Visible = false;
      this.dgvDatos.Columns.Add("pass", "pass");
      this.dgvDatos.Columns[5].DataPropertyName = "pass";
      this.dgvDatos.Columns[5].Width = 100;
      this.dgvDatos.Columns[5].Resizable = DataGridViewTriState.False;
      this.dgvDatos.Columns[5].Visible = false;
      this.dgvDatos.Columns.Add("dump", "dump");
      this.dgvDatos.Columns[6].DataPropertyName = "dump";
      this.dgvDatos.Columns[6].Width = 100;
      this.dgvDatos.Columns[6].Resizable = DataGridViewTriState.False;
      this.dgvDatos.Columns[6].Visible = false;
      this.dgvDatos.Columns.Add("principal", "Predeterminada");
      this.dgvDatos.Columns[7].DataPropertyName = "principal";
      this.dgvDatos.Columns[7].Width = 100;
      this.dgvDatos.Columns[7].Resizable = DataGridViewTriState.False;
    }

    private void cargarDatos()
    {
      try
      {
        this.iniciaFormulario();
        int num = (int) this.dsDatosXml.ReadXml("C:\\AptuSoft\\xml\\config.xml");
        this.dgvDatos.DataSource = (object) this.dsDatosXml.Tables["Conexion"];
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("No hay registros, Ingrese Datos " + ex.Message);
        this.creaXML();
      }
    }

    private void creaXML()
    {
        respaldo_xml_config rp = new respaldo_xml_config();
        rp.recupera();
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
      if (!this.valida())
        return;
      if (this.dsDatosXml.Tables["Conexion"].Select("empresa='" + this.txtEmpresa.Text.Trim() + "'").Length == 0)
      {
        if (this.pruebaConexion())
        {
          DataRow row = this.dsDatosXml.Tables["Conexion"].NewRow();
          row["empresa"] = (object) this.txtEmpresa.Text.Trim();
          row["server"] = (object) this.txtServidor.Text.Trim();
          row["base"] = (object) this.txtBase.Text.Trim();
          row["user"] = (object) this.txtUsuario.Text.Trim();
          row["pass"] = (object) this.txtPass.Text.Trim();
          row["dump"] = (object) "C:/Aptusoft/mysqldump.exe";
          row["rutaRespaldo"] = (object)@"C:\Aptusoft_respaldo";
          row["puerto"] = (object)@"COM5:115200";
          row["rutaElectronica"] = (object)@"C:\AptuSoft\Electronica";
          string str = !this.chkPredeterminada.Checked ? "0" : "1";
          row["principal"] = (object) str;
          if (str.Equals("1"))
          {
            DataRow[] dataRowArray = this.dsDatosXml.Tables["Conexion"].Select("principal=1");
            for (int index = 0; index < dataRowArray.Length; ++index)
              dataRowArray[0]["principal"] = (object) "0";
          }
          this.dsDatosXml.Tables["Conexion"].Rows.Add(row);
          this.dsDatosXml.WriteXml("C:\\AptuSoft\\xml\\config.xml");
          this.cargarDatos();
          respaldo_xml_config rp = new respaldo_xml_config();
          rp.genera_backup();
        }
      }
      else
      {
        int num = (int) MessageBox.Show("Ya Existe una empresa con mismo nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
      catch
      {
        int num = (int) MessageBox.Show("Error al Conectar", "Conexión Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        return false;
      }
    }

    private bool valida()
    {
      if (this.txtEmpresa.Text.Trim().Length == 0)
      {
        int num = (int) MessageBox.Show("Ingrese Nombre de Empresa");
        this.txtEmpresa.Focus();
        return false;
      }
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

    private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.dgvDatos.RowCount <= 0)
        return;
      this._empresa = this.dgvDatos.SelectedRows[0].Cells["empresa"].Value.ToString();
      this.txtEmpresa.Text = this.dgvDatos.SelectedRows[0].Cells["empresa"].Value.ToString();
      this.txtServidor.Text = this.dgvDatos.SelectedRows[0].Cells["server"].Value.ToString();
      this.txtBase.Text = this.dgvDatos.SelectedRows[0].Cells["base"].Value.ToString();
      this.txtUsuario.Text = this.dgvDatos.SelectedRows[0].Cells["user"].Value.ToString();
      this.txtPass.Text = this.dgvDatos.SelectedRows[0].Cells["pass"].Value.ToString();
      this.chkPredeterminada.Checked = this.dgvDatos.SelectedRows[0].Cells["principal"].Value.ToString() == "1";
      this.btnEliminar.Enabled = true;
      this.btnModificar.Enabled = true;
      this.btnGuardar.Enabled = false;
    }

    private void btnEliminar_Click(object sender, EventArgs e)
    {
      if (this.dsDatosXml.Tables["Conexion"].Rows.Count > 1)
      {
        DataRow[] dataRowArray = this.dsDatosXml.Tables["Conexion"].Select("empresa='" + this.txtEmpresa.Text.Trim() + "'");
        for (int index = 0; index < dataRowArray.Length; ++index)
        {
          dataRowArray[0].Delete();
          int num = (int) MessageBox.Show("Eliminada");
        }
        this.dsDatosXml.WriteXml("C:\\AptuSoft\\xml\\config.xml");
        this.cargarDatos();
        respaldo_xml_config rp = new respaldo_xml_config();
        rp.genera_backup();
        int num1 = (int) MessageBox.Show("Registro eliminado", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      else
      {
        int num2 = (int) MessageBox.Show("No se puede eliminar Unico registro", "Elimina", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
      this.cargarDatos();
    }

    private void btnModificar_Click(object sender, EventArgs e)
    {
      if (!this.valida())
        return;
      if ((!this.txtEmpresa.Text.Trim().Equals(this._empresa) ? (this.dsDatosXml.Tables["Conexion"].Select("empresa='" + this.txtEmpresa.Text.Trim() + "'").Length != 0 ? 1 : 0) : 0) == 0)
      {
        if (this.pruebaConexion())
        {
          DataRow[] dataRowArray1 = this.dsDatosXml.Tables["Conexion"].Select("empresa='" + this._empresa + "'");
          string str = !this.chkPredeterminada.Checked ? "0" : "1";
          if (str.Equals("1"))
          {
            DataRow[] dataRowArray2 = this.dsDatosXml.Tables["Conexion"].Select("principal='1'");
            for (int index = 0; index < dataRowArray2.Length; ++index)
              dataRowArray2[0]["principal"] = (object) "0";
          }
          dataRowArray1[0]["empresa"] = (object) this.txtEmpresa.Text.Trim();
          dataRowArray1[0]["server"] = (object) this.txtServidor.Text.Trim();
          dataRowArray1[0]["base"] = (object) this.txtBase.Text.Trim();
          dataRowArray1[0]["user"] = (object) this.txtUsuario.Text.Trim();
          dataRowArray1[0]["pass"] = (object) this.txtPass.Text.Trim();
          dataRowArray1[0]["principal"] = (object) str;
          //dataRowArray1[0]["dump"] = (object) "P:/Aptusoft/mysqldump.exe";
          this.dsDatosXml.WriteXml("C:\\AptuSoft\\xml\\config.xml");
          int num = (int) MessageBox.Show("Registro Modificado", "Modifica", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          respaldo_xml_config rp = new respaldo_xml_config();
          rp.genera_backup();
          this.cargarDatos();
        }
      }
      else
      {
        int num1 = (int) MessageBox.Show("Ya Existe una empresa con mismo nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void lblMuestraTexto_Click(object sender, EventArgs e)
    {
      this.txtEmpresa.UseSystemPasswordChar = !this.txtEmpresa.UseSystemPasswordChar;
      this.txtServidor.UseSystemPasswordChar = !this.txtServidor.UseSystemPasswordChar;
      this.txtUsuario.UseSystemPasswordChar = !this.txtUsuario.UseSystemPasswordChar;
      this.txtBase.UseSystemPasswordChar = !this.txtBase.UseSystemPasswordChar;
      this.txtPass.UseSystemPasswordChar = !this.txtPass.UseSystemPasswordChar;
      this.Refresh();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkPredeterminada = new System.Windows.Forms.CheckBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblMuestraTexto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(44, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servidor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Base de Datos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(47, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(29, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contraseña";
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(96, 35);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(185, 20);
            this.txtServidor.TabIndex = 2;
            this.txtServidor.UseSystemPasswordChar = true;
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(96, 59);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(185, 20);
            this.txtBase.TabIndex = 3;
            this.txtBase.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(96, 83);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(185, 20);
            this.txtUsuario.TabIndex = 4;
            this.txtUsuario.UseSystemPasswordChar = true;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(96, 107);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(185, 20);
            this.txtPass.TabIndex = 5;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(317, 11);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(115, 47);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar y Probar Conexión";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(8, 167);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersVisible = false;
            this.dgvDatos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(424, 180);
            this.dgvDatos.TabIndex = 9;
            this.dgvDatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellDoubleClick);
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(96, 11);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(185, 20);
            this.txtEmpresa.TabIndex = 1;
            this.txtEmpresa.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(42, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Empresa";
            // 
            // chkPredeterminada
            // 
            this.chkPredeterminada.AutoSize = true;
            this.chkPredeterminada.Location = new System.Drawing.Point(96, 133);
            this.chkPredeterminada.Name = "chkPredeterminada";
            this.chkPredeterminada.Size = new System.Drawing.Size(144, 17);
            this.chkPredeterminada.TabIndex = 12;
            this.chkPredeterminada.Text = "Empresa Predeterminada";
            this.chkPredeterminada.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(317, 94);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(115, 23);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(317, 64);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(115, 23);
            this.btnModificar.TabIndex = 14;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(317, 125);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(115, 23);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblMuestraTexto
            // 
            this.lblMuestraTexto.Location = new System.Drawing.Point(396, 355);
            this.lblMuestraTexto.Name = "lblMuestraTexto";
            this.lblMuestraTexto.Size = new System.Drawing.Size(46, 23);
            this.lblMuestraTexto.TabIndex = 24;
            this.lblMuestraTexto.Click += new System.EventHandler(this.lblMuestraTexto_Click);
            // 
            // frmConexion
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(444, 380);
            this.Controls.Add(this.lblMuestraTexto);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.chkPredeterminada);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmpresa);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.txtServidor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmConexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Datos de Conexion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConexion_FormClosing);
            this.Load += new System.EventHandler(this.frmConexion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private void frmConexion_FormClosing(object sender, FormClosingEventArgs e)
    {
        respaldo_xml_config rp = new respaldo_xml_config();
        rp.genera_backup();
    }

    private void frmConexion_Load(object sender, EventArgs e)
    {

    }
  }
}
