 
// Type: Aptusoft.FacturaElectronica.Formularios.frmCaf
 
 
// version 1.8.0

using Aptusoft;
using Aptusoft.FacturaElectronica.Clases;
using Aptusoft.Properties;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace Aptusoft.FacturaElectronica.Formularios
{
  public class frmCaf : Form
  {
    private CafVO _cafVO = new CafVO();
    private IContainer components = (IContainer)null;
    public ComboBox cmbDocumentos;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private TextBox txtDesde;
    private TextBox txtHasta;
    private TextBox txtFecha;
    private Button btnCargarCaf;
    private GroupBox groupBox1;
    private TextBox txtRazonSocial;
    private Label label6;
    private TextBox txtRut;
    private Label label5;
    private DataGridView dgvCaf;
    private GroupBox gpbBotones;
    private Button btnGuardar;
    private Button btnSalir;
    private TabControl tabControl1;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private Button btnGuardaFolio;
    private TextBox txtFolioHasta;
    private TextBox txtFolioDesde;
    private Label label8;
    private Label label9;
    private ComboBox cmbCaja;
    private Label label7;
    private DataGridView dgvFolio;
    private DataGridViewTextBoxColumn idFolio;
    private DataGridViewTextBoxColumn tdfolio;
    private DataGridViewTextBoxColumn caja;
    private DataGridViewTextBoxColumn desde;
    private DataGridViewTextBoxColumn hasta;
    private TextBox txtArchivoCaf;
    private Label label10;
    private DataGridViewTextBoxColumn td;
    private DataGridViewTextBoxColumn rngD;
    private DataGridViewTextBoxColumn rngH;
    private DataGridViewTextBoxColumn Activo;
    private Panel panel1;
    private Label label11;
    private Button btnLimpiar;

    public frmCaf()
    {
      this.InitializeComponent();
      this.dgvCaf.AutoGenerateColumns = false;
      this.dgvFolio.AutoGenerateColumns = false;
      this.iniciaFormulario();
    }

    public void iniciaFormulario()
    {
      this.gpbBotones.Enabled = false;
      this.cargaDocumentos();
      this._cafVO = new CafVO();
      this.txtRut.Clear();
      this.txtRazonSocial.Clear();
      this.txtDesde.Clear();
      this.txtHasta.Clear();
      this.txtFecha.Clear();
      this.txtArchivoCaf.Clear();
      this.cargaListaCaf();
      this.txtFolioDesde.Clear();
      this.txtFolioHasta.Clear();
      this.cmbCaja.SelectedValue = (object) 1;
      this.cargaCajas();
      this.cargaListaFolios();
    }

    private void cargaListaCaf()
    {
      int td = Convert.ToInt32(this.cmbDocumentos.SelectedValue.ToString());
      this.dgvCaf.DataSource = (object) null;
      this.dgvCaf.DataSource = (object) new Caf().listadoCaf(td);
    }

    private void cargaListaFolios()
    {
      int td = Convert.ToInt32(this.cmbDocumentos.SelectedValue.ToString());
      this.dgvFolio.DataSource = (object) null;
      this.dgvFolio.DataSource = (object) new Folios().listadoFolios(td);
    }

    private void cargaDocumentos()
    {
      this.cmbDocumentos.DataSource = (object) new CargaMaestrosElectronica().listaDocumentosVenta();
      this.cmbDocumentos.ValueMember = "Numero";
      this.cmbDocumentos.DisplayMember = "Nombre";
      this.cmbDocumentos.SelectedValue = (object) 33;
    }

    private void cargaCajas()
    {
      this.cmbCaja.DataSource = (object) new CargaMaestros().cargaCajaUsuario();
      this.cmbCaja.ValueMember = "IdCaja";
      this.cmbCaja.DisplayMember = "NombreCaja";
    }

    private void btnCargarCaf_Click(object sender, EventArgs e)
    {
        cargar();
    }
    private void cargar()
    {
        string path = @"C:\Aptusoft\Electronica\";
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = "Archivos XML(*.xml)| *.xml";
        openFileDialog.InitialDirectory = path;
        if (openFileDialog.ShowDialog() != DialogResult.OK)
        {
            return;
        }
        else
        {
            string dir = "";
            if (tpoDoc(openFileDialog.FileName) == "33") { dir = @"E-Factura\"; }
            if (tpoDoc(openFileDialog.FileName) == "39") { dir = @"E-Boleta\"; }
            if (tpoDoc(openFileDialog.FileName) == "34") { dir = @"E-FacturaExenta\"; }
            if (tpoDoc(openFileDialog.FileName) == "56") { dir = @"E-NotaDebito\"; }
            if (tpoDoc(openFileDialog.FileName) == "61") { dir = @"E-NotaCredito\"; }
            if (tpoDoc(openFileDialog.FileName) == "52") { dir = @"E-Guia\"; }
            string[] a = openFileDialog.FileName.Split('\\');
            if (!File.Exists(path + @"caf\" + dir + a[a.Length - 1].ToString()))
            {
                File.Copy(openFileDialog.FileName, path + @"caf\" + dir + a[a.Length - 1].ToString());
            }
            openFileDialog.FileName = path + @"caf\" + dir + a[a.Length - 1].ToString();


        }
        string fileName = openFileDialog.FileName;
        this.txtArchivoCaf.Text = openFileDialog.SafeFileName;
        this.cargaXML(fileName);
        //get_rut(fileName);
        //if (txtRut.ToString().Length == 10 && txtRut.ToString().Length == 9)
        //{
        // MessageBox.Show("largo de rut " + txtRut.ToString().Length);
        //}

        if (!new Caf().buscaCafArchivoConFolios(this._cafVO.TipoDocumento, this._cafVO.Desde, this._cafVO.Hasta))
        {
            this.gpbBotones.Enabled = true;
        }
        else
        {
            int num = (int)MessageBox.Show("El Archivo Caf ya fue cargado Anteriormente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            this.iniciaFormulario();
        }
    }
    private void cargar(string ruta)
    {
        string archivo = ruta;
        string path = @"C:\Aptusoft\Electronica\";
        //OpenFileDialog openFileDialog = new OpenFileDialog();
        //openFileDialog.Filter = "Archivos XML(*.xml)| *.xml";
        //openFileDialog.InitialDirectory = path;
        //if (openFileDialog.ShowDialog() != DialogResult.OK)
        //{
        //    return;
        //}
        //else
        //{
            string dir = "";
            if (tpoDoc(archivo) == "33") { dir = @"E-Factura\"; this.cmbDocumentos.SelectedIndex = 0; }
            if (tpoDoc(archivo) == "39") { dir = @"E-Boleta\"; this.cmbDocumentos.SelectedIndex = 2; }
            if (tpoDoc(archivo) == "34") { dir = @"E-FacturaExenta\"; this.cmbDocumentos.SelectedIndex = 1; }
            if (tpoDoc(archivo) == "56") { dir = @"E-NotaDebito\"; this.cmbDocumentos.SelectedIndex = 5; }
            if (tpoDoc(archivo) == "61") { dir = @"E-NotaCredito\"; this.cmbDocumentos.SelectedIndex = 6; }
            if (tpoDoc(archivo) == "52") { dir = @"E-Guia\"; this.cmbDocumentos.SelectedIndex = 4; }
            string[] a = archivo.Split('\\');
            if (!File.Exists(path + @"caf\" + dir + a[a.Length - 1].ToString()))
            {
                File.Copy(archivo, path + @"caf\" + dir + a[a.Length - 1].ToString());
            }
            archivo = path + @"caf\" + dir + a[a.Length - 1].ToString();


        //}
            string fileName = a[a.Length - 1].ToString();
            this.txtArchivoCaf.Text = a[a.Length - 1].ToString();
            this.cargaXML(archivo);
        //get_rut(fileName);
        //if (txtRut.ToString().Length == 10 && txtRut.ToString().Length == 9)
        //{
        // MessageBox.Show("largo de rut " + txtRut.ToString().Length);
        //}

        if (!new Caf().buscaCafArchivoConFolios(this._cafVO.TipoDocumento, this._cafVO.Desde, this._cafVO.Hasta))
        {
            this.gpbBotones.Enabled = true;
        }
        else
        {
            int num = (int)MessageBox.Show("El Archivo Caf ya fue cargado Anteriormente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            this.iniciaFormulario();
        }
    }
    public int get_rut(string path)
    {
        validarDatosEmisor vl = new validarDatosEmisor();
        XmlDocument xd = new XmlDocument();
        xd.Load(path);
        XmlNodeList nodelist = xd.SelectNodes("AUTORIZACION/CAF/DA");
        bool val = false;
        int largo = 0;
        foreach (XmlNode node in nodelist)
        {
            try
            {
                //MessageBox.Show(node.SelectSingleNode("RE").InnerText);
                if (node.SelectSingleNode("RE").InnerText.Length == 10 || node.SelectSingleNode("RE").InnerText.Length == 9)
                {
                    if (vl.valUser_caf(node.SelectSingleNode("RE").InnerText.Length))
                    {
                        MessageBox.Show("hay rut");
                    }
                }
                else
                {
                    MessageBox.Show("invalido");
                }
            }
            catch (Exception ex)
            {
            }
        }
        return 1;
    }
    private void cargaXML(string ruta)
    {
      try
      {
        DataSet dataSet = new DataSet();
        int num1 = (int) dataSet.ReadXml(ruta);
        if (dataSet.Tables["DA"].Rows[0]["TD"].ToString() == this.cmbDocumentos.SelectedValue.ToString())
        {
          this.txtRut.Text = dataSet.Tables["DA"].Rows[0]["RE"].ToString();
          this.txtRazonSocial.Text = dataSet.Tables["DA"].Rows[0]["RS"].ToString();
          this.txtDesde.Text = dataSet.Tables["RNG"].Rows[0]["D"].ToString();
          this.txtHasta.Text = dataSet.Tables["RNG"].Rows[0]["H"].ToString();
          this.txtFecha.Text = dataSet.Tables["DA"].Rows[0]["FA"].ToString();
          this._cafVO = new CafVO();
          this._cafVO.Desde = Convert.ToInt32(dataSet.Tables["RNG"].Rows[0]["D"].ToString());
          this._cafVO.Hasta = Convert.ToInt32(dataSet.Tables["RNG"].Rows[0]["H"].ToString());
          this._cafVO.RutaArchivo = this.txtArchivoCaf.Text;
          this._cafVO.TipoDocumento = Convert.ToInt32(dataSet.Tables["DA"].Rows[0]["TD"].ToString());
        }
        else
        {
          int num2 = (int) MessageBox.Show("El Archivo, no corresponde al Documento Seleccionado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error " + ex.Message);
      }
    }
    private string tpoDoc(string ruta)
    {
        string tipo = "";
        try
        {
            DataSet dataSet = new DataSet();
            int num1 = (int)dataSet.ReadXml(ruta);
            if (dataSet.Tables["DA"].Rows[0]["TD"].ToString() == this.cmbDocumentos.SelectedValue.ToString())
            {
                tipo = dataSet.Tables["DA"].Rows[0]["TD"].ToString();
            }
            else
            {
               // int num2 = (int)MessageBox.Show("El Archivo, no corresponde al Documento Seleccionado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        catch (Exception ex)
        {
            //int num = (int)MessageBox.Show("Error " + ex.Message);
        }
        return tipo;
    }
    private void frmCAF_Load(object sender, EventArgs e)
    {
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
      new Caf().guardaCAF(this._cafVO);
      SubeXMLToDb sube = new SubeXMLToDb();
      sube.SubeCaf(this._cafVO.TipoDocumento.ToString(), DateTime.Now.ToString("yyyy-MM-dd 00:00:00"), @"\caf\", this.txtArchivoCaf.Text);
      int num = (int) MessageBox.Show("CAF GUARDADO", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      this.iniciaFormulario();
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void cmbDocumentos_SelectedValueChanged(object sender, EventArgs e)
    {
      if (this.cmbDocumentos.SelectedValue == null || !(this.cmbDocumentos.DisplayMember == "Nombre"))
        return;
      this.cargaListaCaf();
      this.cargaListaFolios();
    }

    private void btnGuardaFolio_Click(object sender, EventArgs e)
    {
      try
      {
        new Folios().guardaFolio(new FolioVO()
        {
          Td = Convert.ToInt32(this.cmbDocumentos.SelectedValue.ToString()),
          Caja = Convert.ToInt32(this.cmbCaja.SelectedValue.ToString()),
          Desde = Convert.ToInt32(this.txtFolioDesde.Text.Trim()),
          Hasta = Convert.ToInt32(this.txtFolioHasta.Text.Trim())
        });
        int num = (int) MessageBox.Show("Folio Guardado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.iniciaFormulario();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error " + ex.Message);
      }
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
      this.iniciaFormulario();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbDocumentos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDesde = new System.Windows.Forms.TextBox();
            this.txtHasta = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtArchivoCaf = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCargarCaf = new System.Windows.Forms.Button();
            this.dgvCaf = new System.Windows.Forms.DataGridView();
            this.td = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rngD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rngH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbBotones = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvFolio = new System.Windows.Forms.DataGridView();
            this.idFolio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdfolio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardaFolio = new System.Windows.Forms.Button();
            this.txtFolioHasta = new System.Windows.Forms.TextBox();
            this.txtFolioDesde = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbCaja = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaf)).BeginInit();
            this.gpbBotones.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFolio)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbDocumentos
            // 
            this.cmbDocumentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDocumentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDocumentos.FormattingEnabled = true;
            this.cmbDocumentos.Location = new System.Drawing.Point(12, 34);
            this.cmbDocumentos.Name = "cmbDocumentos";
            this.cmbDocumentos.Size = new System.Drawing.Size(288, 23);
            this.cmbDocumentos.TabIndex = 0;
            this.cmbDocumentos.SelectedValueChanged += new System.EventHandler(this.cmbDocumentos_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo de Documento";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(142, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Desde";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(218, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hasta";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha de Autorizacion";
            // 
            // txtDesde
            // 
            this.txtDesde.BackColor = System.Drawing.Color.White;
            this.txtDesde.Location = new System.Drawing.Point(142, 167);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.ReadOnly = true;
            this.txtDesde.Size = new System.Drawing.Size(73, 20);
            this.txtDesde.TabIndex = 5;
            // 
            // txtHasta
            // 
            this.txtHasta.BackColor = System.Drawing.Color.White;
            this.txtHasta.Location = new System.Drawing.Point(218, 167);
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.ReadOnly = true;
            this.txtHasta.Size = new System.Drawing.Size(73, 20);
            this.txtHasta.TabIndex = 6;
            // 
            // txtFecha
            // 
            this.txtFecha.BackColor = System.Drawing.Color.White;
            this.txtFecha.Location = new System.Drawing.Point(12, 167);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(126, 20);
            this.txtFecha.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtArchivoCaf);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtRazonSocial);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtRut);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbDocumentos);
            this.groupBox1.Controls.Add(this.txtFecha);
            this.groupBox1.Controls.Add(this.txtHasta);
            this.groupBox1.Controls.Add(this.txtDesde);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnCargarCaf);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 198);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // txtArchivoCaf
            // 
            this.txtArchivoCaf.BackColor = System.Drawing.Color.White;
            this.txtArchivoCaf.Location = new System.Drawing.Point(12, 80);
            this.txtArchivoCaf.Name = "txtArchivoCaf";
            this.txtArchivoCaf.ReadOnly = true;
            this.txtArchivoCaf.Size = new System.Drawing.Size(288, 20);
            this.txtArchivoCaf.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(12, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(288, 27);
            this.label10.TabIndex = 13;
            this.label10.Text = "Archivo CAF";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.BackColor = System.Drawing.Color.White;
            this.txtRazonSocial.Location = new System.Drawing.Point(116, 123);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.ReadOnly = true;
            this.txtRazonSocial.Size = new System.Drawing.Size(275, 20);
            this.txtRazonSocial.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(116, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(275, 27);
            this.label6.TabIndex = 11;
            this.label6.Text = "Razon Social";
            // 
            // txtRut
            // 
            this.txtRut.BackColor = System.Drawing.Color.White;
            this.txtRut.Location = new System.Drawing.Point(12, 123);
            this.txtRut.Name = "txtRut";
            this.txtRut.ReadOnly = true;
            this.txtRut.Size = new System.Drawing.Size(100, 20);
            this.txtRut.TabIndex = 10;
            this.txtRut.TextChanged += new System.EventHandler(this.txtRut_TextChanged);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 27);
            this.label5.TabIndex = 9;
            this.label5.Text = "Rut";
            // 
            // btnCargarCaf
            // 
            this.btnCargarCaf.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarCaf.Image = global::Aptusoft.Properties.Resources.descargar_48;
            this.btnCargarCaf.Location = new System.Drawing.Point(306, 16);
            this.btnCargarCaf.Name = "btnCargarCaf";
            this.btnCargarCaf.Size = new System.Drawing.Size(84, 84);
            this.btnCargarCaf.TabIndex = 8;
            this.btnCargarCaf.Text = "Cargar CAF";
            this.btnCargarCaf.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCargarCaf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCargarCaf.UseVisualStyleBackColor = true;
            this.btnCargarCaf.Click += new System.EventHandler(this.btnCargarCaf_Click);
            // 
            // dgvCaf
            // 
            this.dgvCaf.AllowUserToAddRows = false;
            this.dgvCaf.AllowUserToDeleteRows = false;
            this.dgvCaf.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvCaf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.td,
            this.rngD,
            this.rngH,
            this.Activo});
            this.dgvCaf.Location = new System.Drawing.Point(3, 293);
            this.dgvCaf.Name = "dgvCaf";
            this.dgvCaf.ReadOnly = true;
            this.dgvCaf.RowHeadersVisible = false;
            this.dgvCaf.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCaf.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCaf.Size = new System.Drawing.Size(403, 156);
            this.dgvCaf.TabIndex = 10;
            // 
            // td
            // 
            this.td.DataPropertyName = "TipoDocumentoNombre";
            this.td.HeaderText = "Documento";
            this.td.Name = "td";
            this.td.ReadOnly = true;
            this.td.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.td.Width = 177;
            // 
            // rngD
            // 
            this.rngD.DataPropertyName = "Desde";
            this.rngD.HeaderText = "Desde";
            this.rngD.Name = "rngD";
            this.rngD.ReadOnly = true;
            this.rngD.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // rngH
            // 
            this.rngH.DataPropertyName = "Hasta";
            this.rngH.HeaderText = "Hasta";
            this.rngH.Name = "rngH";
            this.rngH.ReadOnly = true;
            this.rngH.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Activo
            // 
            this.Activo.DataPropertyName = "Activo";
            this.Activo.HeaderText = "Activo";
            this.Activo.Name = "Activo";
            this.Activo.ReadOnly = true;
            this.Activo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Activo.Visible = false;
            this.Activo.Width = 80;
            // 
            // gpbBotones
            // 
            this.gpbBotones.Controls.Add(this.btnGuardar);
            this.gpbBotones.Location = new System.Drawing.Point(3, 200);
            this.gpbBotones.Name = "gpbBotones";
            this.gpbBotones.Size = new System.Drawing.Size(84, 86);
            this.gpbBotones.TabIndex = 12;
            this.gpbBotones.TabStop = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.Image = global::Aptusoft.Properties.Resources.guardar_documento_icono_7840_48;
            this.btnGuardar.Location = new System.Drawing.Point(4, 10);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(70, 70);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Image = global::Aptusoft.Properties.Resources.salir_de_mi_perfil_icono_3964_48;
            this.btnSalir.Location = new System.Drawing.Point(323, 210);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(70, 70);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 453);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(403, 31);
            this.tabControl1.TabIndex = 13;
            this.tabControl1.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(395, 4);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lista";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.tabPage2.Controls.Add(this.dgvFolio);
            this.tabPage2.Controls.Add(this.btnGuardaFolio);
            this.tabPage2.Controls.Add(this.txtFolioHasta);
            this.tabPage2.Controls.Add(this.txtFolioDesde);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.cmbCaja);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(395, 5);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Folios";
            // 
            // dgvFolio
            // 
            this.dgvFolio.AllowUserToAddRows = false;
            this.dgvFolio.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvFolio.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFolio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFolio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFolio,
            this.tdfolio,
            this.caja,
            this.desde,
            this.hasta});
            this.dgvFolio.Location = new System.Drawing.Point(3, 60);
            this.dgvFolio.Name = "dgvFolio";
            this.dgvFolio.ReadOnly = true;
            this.dgvFolio.RowHeadersVisible = false;
            this.dgvFolio.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFolio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFolio.Size = new System.Drawing.Size(384, 150);
            this.dgvFolio.TabIndex = 18;
            // 
            // idFolio
            // 
            this.idFolio.DataPropertyName = "idFolio";
            this.idFolio.HeaderText = "idFolio";
            this.idFolio.Name = "idFolio";
            this.idFolio.ReadOnly = true;
            this.idFolio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idFolio.Width = 50;
            // 
            // tdfolio
            // 
            this.tdfolio.DataPropertyName = "td";
            this.tdfolio.HeaderText = "tdfolio";
            this.tdfolio.Name = "tdfolio";
            this.tdfolio.ReadOnly = true;
            this.tdfolio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tdfolio.Width = 60;
            // 
            // caja
            // 
            this.caja.DataPropertyName = "caja";
            this.caja.HeaderText = "caja";
            this.caja.Name = "caja";
            this.caja.ReadOnly = true;
            this.caja.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.caja.Width = 50;
            // 
            // desde
            // 
            this.desde.DataPropertyName = "desde";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = "0";
            this.desde.DefaultCellStyle = dataGridViewCellStyle5;
            this.desde.HeaderText = "desde";
            this.desde.Name = "desde";
            this.desde.ReadOnly = true;
            this.desde.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // hasta
            // 
            this.hasta.DataPropertyName = "hasta";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = "0";
            this.hasta.DefaultCellStyle = dataGridViewCellStyle6;
            this.hasta.HeaderText = "hasta";
            this.hasta.Name = "hasta";
            this.hasta.ReadOnly = true;
            this.hasta.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // btnGuardaFolio
            // 
            this.btnGuardaFolio.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardaFolio.ForeColor = System.Drawing.Color.Black;
            this.btnGuardaFolio.Location = new System.Drawing.Point(267, 17);
            this.btnGuardaFolio.Name = "btnGuardaFolio";
            this.btnGuardaFolio.Size = new System.Drawing.Size(75, 38);
            this.btnGuardaFolio.TabIndex = 2;
            this.btnGuardaFolio.Text = "GUARDAR";
            this.btnGuardaFolio.UseVisualStyleBackColor = true;
            this.btnGuardaFolio.Click += new System.EventHandler(this.btnGuardaFolio_Click);
            // 
            // txtFolioHasta
            // 
            this.txtFolioHasta.BackColor = System.Drawing.Color.White;
            this.txtFolioHasta.Location = new System.Drawing.Point(188, 35);
            this.txtFolioHasta.Name = "txtFolioHasta";
            this.txtFolioHasta.Size = new System.Drawing.Size(73, 20);
            this.txtFolioHasta.TabIndex = 17;
            // 
            // txtFolioDesde
            // 
            this.txtFolioDesde.BackColor = System.Drawing.Color.White;
            this.txtFolioDesde.Location = new System.Drawing.Point(112, 35);
            this.txtFolioDesde.Name = "txtFolioDesde";
            this.txtFolioDesde.Size = new System.Drawing.Size(73, 20);
            this.txtFolioDesde.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(112, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 27);
            this.label8.TabIndex = 14;
            this.label8.Text = "Desde";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(188, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 27);
            this.label9.TabIndex = 15;
            this.label9.Text = "Hasta";
            // 
            // cmbCaja
            // 
            this.cmbCaja.BackColor = System.Drawing.Color.White;
            this.cmbCaja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCaja.FormattingEnabled = true;
            this.cmbCaja.Location = new System.Drawing.Point(5, 33);
            this.cmbCaja.Name = "cmbCaja";
            this.cmbCaja.Size = new System.Drawing.Size(101, 21);
            this.cmbCaja.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(6, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 27);
            this.label7.TabIndex = 13;
            this.label7.Text = "Caja";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiar.Image = global::Aptusoft.Properties.Resources.cambio_de_cepillo_de_escoba_de_barrer_claro_icono_5768_48;
            this.btnLimpiar.Location = new System.Drawing.Point(93, 210);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(70, 70);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label11);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(169, 210);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(148, 70);
            this.panel1.TabIndex = 15;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label11.Location = new System.Drawing.Point(3, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 14);
            this.label11.TabIndex = 0;
            this.label11.Text = "Arrastra Aqui Para Cargarlo";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // frmCaf
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(407, 487);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvCaf);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpbBotones);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "frmCaf";
            this.ShowIcon = false;
            this.Text = "Código de Autorización de Folios (CAF)";
            this.Load += new System.EventHandler(this.frmCAF_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.frmCaf_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.frmCaf_DragEnter);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaf)).EndInit();
            this.gpbBotones.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFolio)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

    }

    private void txtRut_TextChanged(object sender, EventArgs e)
    {
        //rut = 18700195-1 -> 8 or 7 mas 2
        //MessageBox.Show(this.txtRut.ToString().Length.ToString());
    }

    private void label11_Click(object sender, EventArgs e)
    {

    }

    private void panel1_DragEnter(object sender, DragEventArgs e)
    {
        if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        else e.Effect = DragDropEffects.None;
    }

    private void panel1_DragDrop(object sender, DragEventArgs e)
    {

        string[] s = (string[]) e.Data.GetData(DataFormats.FileDrop, false);
        foreach(string a in s){
            cargar(a);
        }
    }

    private void frmCaf_DragDrop(object sender, DragEventArgs e)
    {
        //string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
        //foreach (string a in s)
        //{
        //    cargar(a);
        //}
    }

    private void frmCaf_DragEnter(object sender, DragEventArgs e)
    {
        if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        else e.Effect = DragDropEffects.None;
    }
  }
}
