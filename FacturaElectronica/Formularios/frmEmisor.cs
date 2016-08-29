 
// Type: Aptusoft.FacturaElectronica.Formularios.frmEmisor
 
 
// version 1.8.0

using Aptusoft;
using Aptusoft.FacturaElectronica.Clases;
using Aptusoft.FacturaElectronica.Clases.FirmaTimbreXML;
using Aptusoft.Properties;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System.Xml;
using System.Collections;
using System.IO;

namespace Aptusoft.FacturaElectronica.Formularios
{
  public class frmEmisor : Form
  {
    private string _rutaElectronica = "";
    private IContainer components = (IContainer) null;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private Label label6;
    private Label label7;
    private Label label8;
    private Label label9;
    private TextBox txtCiudad;
    private TextBox txtComuna;
    private TextBox txtDireccion;
    private TextBox txtCodigoSucursal;
    private TextBox txtCodigoActEco;
    private TextBox txtGiro;
    private TextBox txtRazonSocial;
    private TextBox txtRut;
    private Button btnGuardar;
    private Button btnLimpiar;
    private Button btnSalir;
    private Panel panelPrincipal;
    private TextBox txtFechaResolucion;
    private Label label11;
    private TextBox txtNumeroResolucion;
    private Label label10;
    private TextBox txtMes;
    private TextBox txtAno;
    private TextBox txtDia;
    private TextBox txtCertificadoDigital;
    private Label label12;
    private TextBox txtRutCertificado;
    private Label label13;
    private Button btnComprobar;
    private CheckBox chkSimulacion;
    private GroupBox groupBox1;

    public frmEmisor()
    {
      this.InitializeComponent();
      this.CargaRuta();
      this.iniciaFormulario();
    }

    private void CargaRuta()
    {
      try
      {
        DataSet dataSet = new DataSet("datos");
        int num = (int) dataSet.ReadXml("C:\\AptuSoft\\xml\\config.xml");
        string filterExpression = "principal=1";
        DataRow[] dataRowArray = dataSet.Tables["conexion"].Select(filterExpression);
        string str = "";
        for (int index = 0; index < dataRowArray.Length; ++index)
          str = dataRowArray[index]["rutaElectronica"].ToString();
        this._rutaElectronica = str.Replace("\\", "\\\\") + "\\\\";
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al Cargar Ruta " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void iniciaFormulario()
    {
      this.txtRut.Clear();
      this.txtRazonSocial.Clear();
      this.txtGiro.Clear();
      this.txtCodigoActEco.Clear();
      this.txtCodigoSucursal.Clear();
      this.txtDireccion.Clear();
      this.txtComuna.Clear();
      this.txtCiudad.Clear();
      this.txtNumeroResolucion.Clear();
      this.txtFechaResolucion.Clear();
      this.txtDia.Clear();
      this.txtMes.Clear();
      this.txtAno.Clear();
      this.txtCertificadoDigital.Clear();
      this.txtRutCertificado.Clear();
      this.panelPrincipal.TabIndex = 0;
      this.txtRut.Focus();
      this.chkSimulacion.Checked = false;
      this.buscaEmisor();
    }

    private void buscaEmisor()
    {
      EmisorVO emisorVo = new Emisor().buscaEmisor();
      if (emisorVo.RutEmisior == null)
        return;
      this.txtRut.Text = emisorVo.RutEmisior;
      this.txtRazonSocial.Text = emisorVo.RazonSocial;
      this.txtGiro.Text = emisorVo.Giro;
      this.txtCodigoActEco.Text = emisorVo.CodActCome;
      this.txtCodigoSucursal.Text = emisorVo.CodSucursal;
      this.txtDireccion.Text = emisorVo.Direccion;
      this.txtComuna.Text = emisorVo.Comuna;
      this.txtCiudad.Text = emisorVo.Ciudad;
      this.txtNumeroResolucion.Text = emisorVo.NumeroResolucion;
      if (emisorVo.FechaResolucion.Length > 0)
      {
        this.txtDia.Text = emisorVo.FechaResolucion.Substring(0, 2);
        this.txtMes.Text = emisorVo.FechaResolucion.Substring(3, 2);
        this.txtAno.Text = emisorVo.FechaResolucion.Substring(6, 4);
        this.txtFechaResolucion.Text = emisorVo.FechaResolucion;
      }
      this.txtCertificadoDigital.Text = emisorVo.CertificadoDigital;
      this.txtRutCertificado.Text = emisorVo.RutCertificado;
      this.chkSimulacion.Checked = emisorVo.Simulacion;
      this.txtRut.Focus();
    }

    private bool validar()
    {
      if (this.txtRut.Text.Trim().Length == 0)
      {
        int num = (int) MessageBox.Show("Debe Ingresar Todos los Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.txtRut.Focus();
        return false;
      }
      if (this.txtRut.Text.Trim().Length > 2)
      {
        ValidaDigito validaDigito1 = new ValidaDigito();
        string str1 = this.txtRut.Text.Substring(this.txtRut.Text.Trim().Length - 1, 1);
        string str2 = this.txtRut.Text.Substring(0, this.txtRut.Text.Trim().Length - 2);
        if (!validaDigito1.digitoVerificador(Convert.ToInt32(str2)).Equals(str1))
        {
          int num = (int) MessageBox.Show("Rut no Valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          this.txtRut.Focus();
          return false;
        }
        if (this.txtRazonSocial.Text.Trim().Length == 0)
        {
          int num = (int) MessageBox.Show("Debe Ingresar Todos los Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          this.txtRazonSocial.Focus();
          return false;
        }
        if (this.txtGiro.Text.Trim().Length == 0)
        {
          int num = (int) MessageBox.Show("Debe Ingresar Todos los Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          this.txtGiro.Focus();
          return false;
        }
        if (this.txtCodigoActEco.Text.Trim().Length == 0)
        {
          int num = (int) MessageBox.Show("Debe Ingresar Todos los Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          this.txtCodigoActEco.Focus();
          return false;
        }
        if (this.txtCodigoSucursal.Text.Trim().Length == 0)
        {
          int num = (int) MessageBox.Show("Debe Ingresar Todos los Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          this.txtCodigoSucursal.Focus();
          return false;
        }
        if (this.txtDireccion.Text.Trim().Length == 0)
        {
          int num = (int) MessageBox.Show("Debe Ingresar Todos los Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          this.txtDireccion.Focus();
          return false;
        }
        if (this.txtComuna.Text.Trim().Length == 0)
        {
          int num = (int) MessageBox.Show("Debe Ingresar Todos los Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          this.txtComuna.Focus();
          return false;
        }
        if (this.txtCiudad.Text.Trim().Length == 0)
        {
          int num = (int) MessageBox.Show("Debe Ingresar Todos los Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          this.txtCiudad.Focus();
          return false;
        }
        if (this.txtNumeroResolucion.Text.Trim().Length == 0)
        {
          int num = (int) MessageBox.Show("Debe Ingresar Todos los Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          this.txtNumeroResolucion.Focus();
          return false;
        }
        if (this.txtFechaResolucion.Text.Trim().Length == 0)
        {
          int num = (int) MessageBox.Show("Debe Ingresar Todos los Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          this.txtDia.Focus();
          return false;
        }
        if (this.txtFechaResolucion.Text.Trim().Length != 10)
        {
          int num = (int) MessageBox.Show("La fecha se encuentra mal ingresada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          this.txtDia.Focus();
          return false;
        }
        if (this.txtCertificadoDigital.Text.Trim().Length == 0)
        {
          int num = (int) MessageBox.Show("Debe Ingresar Todos los Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          this.txtCertificadoDigital.Focus();
          return false;
        }
        if (this.txtRutCertificado.Text.Trim().Length == 0)
        {
          int num = (int) MessageBox.Show("Debe Ingresar Todos los Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          this.txtRutCertificado.Focus();
          return false;
        }
        if (this.txtRutCertificado.Text.Trim().Length > 2)
        {
          ValidaDigito validaDigito2 = new ValidaDigito();
          string str3 = this.txtRutCertificado.Text.Substring(this.txtRutCertificado.Text.Trim().Length - 1, 1);
          string str4 = this.txtRutCertificado.Text.Substring(0, this.txtRutCertificado.Text.Trim().Length - 2);
          if (validaDigito2.digitoVerificador(Convert.ToInt32(str4)).Equals(str3))
            return true;
          int num = (int) MessageBox.Show("Rut no Valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          this.txtRutCertificado.Focus();
          return false;
        }
        int num1 = (int) MessageBox.Show("Rut no Valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.txtRutCertificado.Focus();
        return false;
      }
      int num2 = (int) MessageBox.Show("Rut no Valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      this.txtRut.Focus();
      return false;
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
      if (!this.validar())
        return;
      EmisorVO em = new EmisorVO();
      em.RutEmisior = this.txtRut.Text;
      em.RazonSocial = this.txtRazonSocial.Text;
      em.Giro = this.txtGiro.Text;
      em.CodActCome = this.txtCodigoActEco.Text;
      em.CodSucursal = this.txtCodigoSucursal.Text;
      em.Direccion = this.txtDireccion.Text;
      em.Comuna = this.txtComuna.Text;
      em.Ciudad = this.txtCiudad.Text;
      em.NumeroResolucion = this.txtNumeroResolucion.Text;
      em.FechaResolucion = this.txtFechaResolucion.Text;
      em.CertificadoDigital = this.txtCertificadoDigital.Text;
      em.RutCertificado = this.txtRutCertificado.Text;
      em.Simulacion = this.chkSimulacion.Checked;
      try
      {
        new Emisor().guardaEmisor(em);
        this.modificaXMLdatosSet();
        int num = (int) MessageBox.Show("Datos Guardados", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.iniciaFormulario();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("error " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void modificaXMLdatosSet()
    {
        ArrayList arrayList = new ArrayList();
        String archivo = new LeeXml().cargarDatosMultiEmpresa("factura")[1].ToString();
        if (this._rutaElectronica.Length == 0)
            this.CargaRuta();
        //verrificar archivos de control de xml
        
            string filename1 = this._rutaElectronica + "Archivos\\SETDTE.xml";
            XmlDocument xmlDocument1 = new XmlDocument();
            xmlDocument1.PreserveWhitespace = true;
            xmlDocument1.Load(filename1);
            xmlDocument1.SelectSingleNode("EnvioDTE/SetDTE/Caratula/RutEmisor").InnerText = this.txtRut.Text;
            xmlDocument1.SelectSingleNode("EnvioDTE/SetDTE/Caratula/RutEnvia").InnerText = this.txtRutCertificado.Text;
            xmlDocument1.SelectSingleNode("EnvioDTE/SetDTE/Caratula/RutReceptor").InnerText = "60803000-K";
            xmlDocument1.SelectSingleNode("EnvioDTE/SetDTE/Caratula/FchResol").InnerText = this.txtAno.Text + "-" + this.txtMes.Text + "-" + this.txtDia.Text;
            xmlDocument1.SelectSingleNode("EnvioDTE/SetDTE/Caratula/NroResol").InnerText = this.txtNumeroResolucion.Text;
            xmlDocument1.Save(filename1);
            string filename3 = this._rutaElectronica + "Archivos\\SETDTE_" + archivo + ".xml";
            System.IO.File.Copy(filename1, filename3, true);
            string filename2 = this._rutaElectronica + "Archivos\\SETDTE_ENVIO.XML";
            XmlDocument xmlDocument2 = new XmlDocument();
            xmlDocument2.PreserveWhitespace = true;
            xmlDocument2.Load(filename2);
            xmlDocument2.SelectSingleNode("EnvioDTE/SetDTE/Caratula/RutEmisor").InnerText = this.txtRut.Text;
            xmlDocument2.SelectSingleNode("EnvioDTE/SetDTE/Caratula/RutEnvia").InnerText = this.txtRutCertificado.Text;
            xmlDocument2.SelectSingleNode("EnvioDTE/SetDTE/Caratula/RutReceptor").InnerText = "60803000-K";
            xmlDocument2.SelectSingleNode("EnvioDTE/SetDTE/Caratula/FchResol").InnerText = this.txtAno.Text + "-" + this.txtMes.Text + "-" + this.txtDia.Text;
            xmlDocument2.SelectSingleNode("EnvioDTE/SetDTE/Caratula/NroResol").InnerText = this.txtNumeroResolucion.Text;
            xmlDocument2.Save(filename2);
            string filename4 = this._rutaElectronica + "Archivos\\SETDTE_ENVIO_" + archivo + ".xml";
            System.IO.File.Copy(filename2, filename4, true);
        //encabezado dte boletas
            string filename5 = this._rutaElectronica + "Archivos\\SETDTEBOLETA.XML";
            XmlDocument xmlDocument5 = new XmlDocument();
            xmlDocument5.PreserveWhitespace = true;
            xmlDocument5.Load(filename5);
            xmlDocument5.SelectSingleNode("EnvioBOLETA/SetDTE/Caratula/RutEmisor").InnerText = this.txtRut.Text;
            xmlDocument5.SelectSingleNode("EnvioBOLETA/SetDTE/Caratula/RutEnvia").InnerText = this.txtRutCertificado.Text;
            xmlDocument5.SelectSingleNode("EnvioBOLETA/SetDTE/Caratula/RutReceptor").InnerText = "60803000-K";
            xmlDocument5.SelectSingleNode("EnvioBOLETA/SetDTE/Caratula/FchResol").InnerText = this.txtAno.Text + "-" + this.txtMes.Text + "-" + this.txtDia.Text;
            xmlDocument5.SelectSingleNode("EnvioBOLETA/SetDTE/Caratula/NroResol").InnerText = this.txtNumeroResolucion.Text;
            xmlDocument5.Save(filename5);
            string filename6 = this._rutaElectronica + "Archivos\\SETDTEBOLETA_" + archivo + ".xml";
            System.IO.File.Copy(filename5, filename6, true);
        
    }
       

    private void soloNumerosRut(KeyPressEventArgs e)
    {
      string str = "0123456789-kK";
      if ((int) e.KeyChar == 46)
        e.KeyChar = ',';
      if (str.Contains(string.Concat((object) e.KeyChar)) || (int) e.KeyChar == 8)
        e.Handled = false;
      else
        e.Handled = true;
    }

    private void soloNumerost(KeyPressEventArgs e)
    {
      string str = "0123456789";
      if ((int) e.KeyChar == 46)
        e.KeyChar = ',';
      if (str.Contains(string.Concat((object) e.KeyChar)) || (int) e.KeyChar == 8)
        e.Handled = false;
      else
        e.Handled = true;
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
      this.iniciaFormulario();
    }

    private void txtRut_TextChanged(object sender, EventArgs e)
    {
      if (this.txtRut.Text.Trim().Length <= 1)
        return;
      this.txtRut.Text = this.armaRut(this.txtRut.Text);
      this.txtRut.Select(this.txtRut.Text.Length, 0);
    }

    private string armaRut(string rut)
    {
      rut = rut.Replace("-", "");
      string str = rut.Substring(rut.Length - 1, 1);
      rut = rut.Substring(0, rut.Length - 1) + "-" + str;
      return rut;
    }

    private void txtRut_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumerosRut(e);
    }

    private void txtCodigoActEco_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumerost(e);
    }

    private void txtCodigoSucursal_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumerost(e);
    }

    private void txtNumeroResolucion_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumerost(e);
    }

    private void txtDia_TextChanged(object sender, EventArgs e)
    {
      if (this.txtDia.Text.Trim().Length == 2)
        this.txtMes.Focus();
      this.armaFecha();
    }

    private void txtMes_TextChanged(object sender, EventArgs e)
    {
      if (this.txtMes.Text.Trim().Length == 2)
        this.txtAno.Focus();
      this.armaFecha();
    }

    private void txtAno_TextChanged(object sender, EventArgs e)
    {
      this.armaFecha();
    }

    private void armaFecha()
    {
      this.txtFechaResolucion.Text = this.txtDia.Text + "-" + this.txtMes.Text + "-" + this.txtAno.Text;
    }

    private void txtDia_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumerost(e);
    }

    private void txtMes_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumerost(e);
    }

    private void txtAno_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumerost(e);
    }

    private void txtRutCertificado_TextChanged(object sender, EventArgs e)
    {
      if (this.txtRut.Text.Trim().Length <= 1)
        return;
      this.txtRut.Text = this.armaRut(this.txtRut.Text);
      this.txtRut.Select(this.txtRut.Text.Length, 0);
    }

    private void txtRutCertificado_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumerosRut(e);
    }

    private void btnComprobar_Click(object sender, EventArgs e)
    {
      string CN = this.txtCertificadoDigital.Text.Trim();
      if (CN.Length <= 0)
        return;
      X509Certificate2 x509Certificate2 = FuncionesComunes.RecuperarCertificado(CN);
      if (x509Certificate2 != null)
      {
        string name = x509Certificate2.SubjectName.Name;
        int num1 = (int) MessageBox.Show(name);
        int startIndex = name.IndexOf("CN=");
        int num2 = name.IndexOf(",", startIndex);
        string str = name.Substring(startIndex + 3, num2 - startIndex - 3);
        if (x509Certificate2 == null)
        {
          int num3 = (int) MessageBox.Show("No hay cargados certificados Digitales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
        else if (this.txtCertificadoDigital.Text.Equals(str))
        {
          int num4 = (int) MessageBox.Show("Certificado Verificado Correctamente " + x509Certificate2.FriendlyName, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        else
        {
          int num5 = (int) MessageBox.Show("No se encuentra el certificado Ingresado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
      }
      else
      {
        int num = (int) MessageBox.Show("No se encuentra el certificado Ingresado ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.txtGiro = new System.Windows.Forms.TextBox();
            this.txtCodigoActEco = new System.Windows.Forms.TextBox();
            this.txtCodigoSucursal = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtComuna = new System.Windows.Forms.TextBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRutCertificado = new System.Windows.Forms.TextBox();
            this.btnComprobar = new System.Windows.Forms.Button();
            this.txtCertificadoDigital = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.chkSimulacion = new System.Windows.Forms.CheckBox();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.txtNumeroResolucion = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFechaResolucion = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panelPrincipal.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Rut";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(126, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(356, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Razon Social";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(471, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "Giro";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 24);
            this.label4.TabIndex = 19;
            this.label4.Text = "Codigo de Actividad Economica";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(263, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 24);
            this.label5.TabIndex = 20;
            this.label5.Text = "Codigo de Sucursal";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(11, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(471, 24);
            this.label6.TabIndex = 21;
            this.label6.Text = "Direccion";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(11, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(235, 24);
            this.label7.TabIndex = 22;
            this.label7.Text = "Comuna";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(263, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(219, 24);
            this.label8.TabIndex = 23;
            this.label8.Text = "Ciudad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(290, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(198, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Datos se deben obtener del portal de SII";
            // 
            // txtRut
            // 
            this.txtRut.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRut.Location = new System.Drawing.Point(11, 38);
            this.txtRut.MaxLength = 10;
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(108, 20);
            this.txtRut.TabIndex = 1;
            this.txtRut.TextChanged += new System.EventHandler(this.txtRut_TextChanged);
            this.txtRut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRut_KeyPress);
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtRazonSocial.Location = new System.Drawing.Point(126, 38);
            this.txtRazonSocial.MaxLength = 100;
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(356, 20);
            this.txtRazonSocial.TabIndex = 2;
            // 
            // txtGiro
            // 
            this.txtGiro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtGiro.Location = new System.Drawing.Point(11, 78);
            this.txtGiro.MaxLength = 80;
            this.txtGiro.Name = "txtGiro";
            this.txtGiro.Size = new System.Drawing.Size(471, 20);
            this.txtGiro.TabIndex = 3;
            // 
            // txtCodigoActEco
            // 
            this.txtCodigoActEco.Location = new System.Drawing.Point(11, 118);
            this.txtCodigoActEco.MaxLength = 6;
            this.txtCodigoActEco.Name = "txtCodigoActEco";
            this.txtCodigoActEco.Size = new System.Drawing.Size(235, 20);
            this.txtCodigoActEco.TabIndex = 4;
            this.txtCodigoActEco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoActEco_KeyPress);
            // 
            // txtCodigoSucursal
            // 
            this.txtCodigoSucursal.Location = new System.Drawing.Point(263, 118);
            this.txtCodigoSucursal.MaxLength = 9;
            this.txtCodigoSucursal.Name = "txtCodigoSucursal";
            this.txtCodigoSucursal.Size = new System.Drawing.Size(219, 20);
            this.txtCodigoSucursal.TabIndex = 5;
            this.txtCodigoSucursal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoSucursal_KeyPress);
            // 
            // txtDireccion
            // 
            this.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtDireccion.Location = new System.Drawing.Point(11, 158);
            this.txtDireccion.MaxLength = 70;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(471, 20);
            this.txtDireccion.TabIndex = 6;
            // 
            // txtComuna
            // 
            this.txtComuna.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtComuna.Location = new System.Drawing.Point(11, 200);
            this.txtComuna.MaxLength = 20;
            this.txtComuna.Name = "txtComuna";
            this.txtComuna.Size = new System.Drawing.Size(235, 20);
            this.txtComuna.TabIndex = 7;
            // 
            // txtCiudad
            // 
            this.txtCiudad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCiudad.Location = new System.Drawing.Point(263, 200);
            this.txtCiudad.MaxLength = 20;
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(219, 20);
            this.txtCiudad.TabIndex = 8;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.panelPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPrincipal.Controls.Add(this.groupBox1);
            this.panelPrincipal.Controls.Add(this.txtMes);
            this.panelPrincipal.Controls.Add(this.txtAno);
            this.panelPrincipal.Controls.Add(this.chkSimulacion);
            this.panelPrincipal.Controls.Add(this.label9);
            this.panelPrincipal.Controls.Add(this.txtDia);
            this.panelPrincipal.Controls.Add(this.txtNumeroResolucion);
            this.panelPrincipal.Controls.Add(this.txtCiudad);
            this.panelPrincipal.Controls.Add(this.txtComuna);
            this.panelPrincipal.Controls.Add(this.txtDireccion);
            this.panelPrincipal.Controls.Add(this.txtCodigoSucursal);
            this.panelPrincipal.Controls.Add(this.txtCodigoActEco);
            this.panelPrincipal.Controls.Add(this.txtGiro);
            this.panelPrincipal.Controls.Add(this.txtRazonSocial);
            this.panelPrincipal.Controls.Add(this.txtRut);
            this.panelPrincipal.Controls.Add(this.label11);
            this.panelPrincipal.Controls.Add(this.label10);
            this.panelPrincipal.Controls.Add(this.label1);
            this.panelPrincipal.Controls.Add(this.label6);
            this.panelPrincipal.Controls.Add(this.label7);
            this.panelPrincipal.Controls.Add(this.label3);
            this.panelPrincipal.Controls.Add(this.label8);
            this.panelPrincipal.Controls.Add(this.label2);
            this.panelPrincipal.Controls.Add(this.label5);
            this.panelPrincipal.Controls.Add(this.label4);
            this.panelPrincipal.Location = new System.Drawing.Point(4, 5);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(495, 412);
            this.panelPrincipal.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRutCertificado);
            this.groupBox1.Controls.Add(this.btnComprobar);
            this.groupBox1.Controls.Add(this.txtCertificadoDigital);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(7, 266);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 102);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Certificado Digital";
            // 
            // txtRutCertificado
            // 
            this.txtRutCertificado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRutCertificado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtRutCertificado.Location = new System.Drawing.Point(7, 76);
            this.txtRutCertificado.MaxLength = 70;
            this.txtRutCertificado.Name = "txtRutCertificado";
            this.txtRutCertificado.Size = new System.Drawing.Size(232, 20);
            this.txtRutCertificado.TabIndex = 28;
            this.txtRutCertificado.TextChanged += new System.EventHandler(this.txtRutCertificado_TextChanged);
            this.txtRutCertificado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRutCertificado_KeyPress);
            // 
            // btnComprobar
            // 
            this.btnComprobar.Image = global::Aptusoft.Properties.Resources.comprobar_si_puede_icono_8214_48;
            this.btnComprobar.Location = new System.Drawing.Point(397, 18);
            this.btnComprobar.Name = "btnComprobar";
            this.btnComprobar.Size = new System.Drawing.Size(70, 70);
            this.btnComprobar.TabIndex = 30;
            this.btnComprobar.Text = "Comprobar ";
            this.btnComprobar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnComprobar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnComprobar.UseVisualStyleBackColor = true;
            this.btnComprobar.Click += new System.EventHandler(this.btnComprobar_Click);
            // 
            // txtCertificadoDigital
            // 
            this.txtCertificadoDigital.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtCertificadoDigital.Location = new System.Drawing.Point(6, 35);
            this.txtCertificadoDigital.MaxLength = 70;
            this.txtCertificadoDigital.Name = "txtCertificadoDigital";
            this.txtCertificadoDigital.Size = new System.Drawing.Size(385, 20);
            this.txtCertificadoDigital.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label12.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(6, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(385, 24);
            this.label12.TabIndex = 27;
            this.label12.Text = "Nombre del Certificado Digital";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label13.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(7, 59);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(232, 24);
            this.label13.TabIndex = 29;
            this.label13.Text = "Rut Usuario del Certificado Digital";
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(324, 243);
            this.txtMes.MaxLength = 2;
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(58, 20);
            this.txtMes.TabIndex = 11;
            this.txtMes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMes.TextChanged += new System.EventHandler(this.txtMes_TextChanged);
            this.txtMes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMes_KeyPress);
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(389, 243);
            this.txtAno.MaxLength = 4;
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(93, 20);
            this.txtAno.TabIndex = 12;
            this.txtAno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAno.TextChanged += new System.EventHandler(this.txtAno_TextChanged);
            this.txtAno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAno_KeyPress);
            // 
            // chkSimulacion
            // 
            this.chkSimulacion.AutoSize = true;
            this.chkSimulacion.Location = new System.Drawing.Point(347, 383);
            this.chkSimulacion.Name = "chkSimulacion";
            this.chkSimulacion.Size = new System.Drawing.Size(134, 17);
            this.chkSimulacion.TabIndex = 31;
            this.chkSimulacion.Text = "Proceso de Simulacion";
            this.chkSimulacion.UseVisualStyleBackColor = true;
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(263, 243);
            this.txtDia.MaxLength = 2;
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(55, 20);
            this.txtDia.TabIndex = 10;
            this.txtDia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDia.TextChanged += new System.EventHandler(this.txtDia_TextChanged);
            this.txtDia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDia_KeyPress);
            // 
            // txtNumeroResolucion
            // 
            this.txtNumeroResolucion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumeroResolucion.Location = new System.Drawing.Point(11, 243);
            this.txtNumeroResolucion.MaxLength = 20;
            this.txtNumeroResolucion.Name = "txtNumeroResolucion";
            this.txtNumeroResolucion.Size = new System.Drawing.Size(235, 20);
            this.txtNumeroResolucion.TabIndex = 9;
            this.txtNumeroResolucion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroResolucion_KeyPress);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(263, 225);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(219, 18);
            this.label11.TabIndex = 25;
            this.label11.Text = "Fecha Resolucion dia-mes-año";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(11, 225);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(235, 24);
            this.label10.TabIndex = 24;
            this.label10.Text = "N° Resolucion";
            // 
            // txtFechaResolucion
            // 
            this.txtFechaResolucion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFechaResolucion.Location = new System.Drawing.Point(211, 472);
            this.txtFechaResolucion.MaxLength = 20;
            this.txtFechaResolucion.Name = "txtFechaResolucion";
            this.txtFechaResolucion.Size = new System.Drawing.Size(197, 20);
            this.txtFechaResolucion.TabIndex = 19;
            this.txtFechaResolucion.Visible = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = global::Aptusoft.Properties.Resources.salir_de_mi_perfil_icono_3964_48;
            this.btnSalir.Location = new System.Drawing.Point(424, 426);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(70, 70);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Image = global::Aptusoft.Properties.Resources.cambio_de_cepillo_de_escoba_de_barrer_claro_icono_5768_48;
            this.btnLimpiar.Location = new System.Drawing.Point(88, 426);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(70, 70);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::Aptusoft.Properties.Resources.guardar_documento_icono_7840_48;
            this.btnGuardar.Location = new System.Drawing.Point(7, 426);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(70, 70);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmEmisor
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(507, 501);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtFechaResolucion);
            this.MaximizeBox = false;
            this.Name = "frmEmisor";
            this.ShowIcon = false;
            this.Text = "Informacion de Emisor de Facturacion Electronica";
            this.Load += new System.EventHandler(this.frmEmisor_Load);
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private void frmEmisor_Load(object sender, EventArgs e)
    {

    }
  }
}
