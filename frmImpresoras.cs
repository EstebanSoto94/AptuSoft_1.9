 
// Type: Aptusoft.frmImpresoras
 
 
// version 1.8.0

using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Xml;

namespace Aptusoft
{
  public class frmImpresoras : Form
  {
    private IContainer components = (IContainer) null;
    private bool _guarda = false;
    private Label label1;
    private ComboBox cmbImpresoraFactura;
    private Button btnGuardar;
    private GroupBox groupBox1;
    private Button btnSalir;
    private ComboBox cmbImpresoraOtrosDocumentos;
    private Label label2;
    private Label label4;
    private ComboBox cmbImpresoraTicket;
    private Label label3;
    private ComboBox cmbImpresoraBoleta;
    private Label label5;
    private ComboBox cmbImpresoraGuia;
    private Label label7;
    private ComboBox cmbImpresoraCotizacion;
    private Label label6;
    private ComboBox cmbImpresoraNotaCredito;
    private Label label8;
    private ComboBox cmbComanda;
    private Label label10;
    private ComboBox cmbImpresoraCodigosBarra;
    private Label label9;
    private ComboBox cmbImpresoraNotaVenta;

    public frmImpresoras()
    {
      this.InitializeComponent();
      this.cargaPermisos();
      this.cargaComboImpresoras();
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbImpresoraFactura = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbComanda = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbImpresoraCodigosBarra = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbImpresoraNotaVenta = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbImpresoraCotizacion = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbImpresoraNotaCredito = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbImpresoraGuia = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbImpresoraTicket = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbImpresoraBoleta = new System.Windows.Forms.ComboBox();
            this.cmbImpresoraOtrosDocumentos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Factura de Venta:";
            // 
            // cmbImpresoraFactura
            // 
            this.cmbImpresoraFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbImpresoraFactura.FormattingEnabled = true;
            this.cmbImpresoraFactura.Location = new System.Drawing.Point(137, 32);
            this.cmbImpresoraFactura.Name = "cmbImpresoraFactura";
            this.cmbImpresoraFactura.Size = new System.Drawing.Size(207, 21);
            this.cmbImpresoraFactura.TabIndex = 1;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(12, 354);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbComanda);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cmbImpresoraCodigosBarra);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cmbImpresoraNotaVenta);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbImpresoraCotizacion);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbImpresoraNotaCredito);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbImpresoraGuia);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbImpresoraTicket);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbImpresoraBoleta);
            this.groupBox1.Controls.Add(this.cmbImpresoraOtrosDocumentos);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbImpresoraFactura);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 325);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Maestro de Impresoras";
            // 
            // cmbComanda
            // 
            this.cmbComanda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbComanda.FormattingEnabled = true;
            this.cmbComanda.Location = new System.Drawing.Point(137, 259);
            this.cmbComanda.Name = "cmbComanda";
            this.cmbComanda.Size = new System.Drawing.Size(207, 21);
            this.cmbComanda.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 262);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 15);
            this.label10.TabIndex = 22;
            this.label10.Text = "Comanda:";
            // 
            // cmbImpresoraCodigosBarra
            // 
            this.cmbImpresoraCodigosBarra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbImpresoraCodigosBarra.FormattingEnabled = true;
            this.cmbImpresoraCodigosBarra.Location = new System.Drawing.Point(137, 229);
            this.cmbImpresoraCodigosBarra.Name = "cmbImpresoraCodigosBarra";
            this.cmbImpresoraCodigosBarra.Size = new System.Drawing.Size(207, 21);
            this.cmbImpresoraCodigosBarra.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "Codigo de Barra:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Nota de Venta:";
            // 
            // cmbImpresoraNotaVenta
            // 
            this.cmbImpresoraNotaVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbImpresoraNotaVenta.FormattingEnabled = true;
            this.cmbImpresoraNotaVenta.Location = new System.Drawing.Point(137, 201);
            this.cmbImpresoraNotaVenta.Name = "cmbImpresoraNotaVenta";
            this.cmbImpresoraNotaVenta.Size = new System.Drawing.Size(207, 21);
            this.cmbImpresoraNotaVenta.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Cotizacion:";
            // 
            // cmbImpresoraCotizacion
            // 
            this.cmbImpresoraCotizacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbImpresoraCotizacion.FormattingEnabled = true;
            this.cmbImpresoraCotizacion.Location = new System.Drawing.Point(137, 172);
            this.cmbImpresoraCotizacion.Name = "cmbImpresoraCotizacion";
            this.cmbImpresoraCotizacion.Size = new System.Drawing.Size(207, 21);
            this.cmbImpresoraCotizacion.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nota de Credito:";
            // 
            // cmbImpresoraNotaCredito
            // 
            this.cmbImpresoraNotaCredito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbImpresoraNotaCredito.FormattingEnabled = true;
            this.cmbImpresoraNotaCredito.Location = new System.Drawing.Point(137, 144);
            this.cmbImpresoraNotaCredito.Name = "cmbImpresoraNotaCredito";
            this.cmbImpresoraNotaCredito.Size = new System.Drawing.Size(207, 21);
            this.cmbImpresoraNotaCredito.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Guia de Despacho :";
            // 
            // cmbImpresoraGuia
            // 
            this.cmbImpresoraGuia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbImpresoraGuia.FormattingEnabled = true;
            this.cmbImpresoraGuia.Location = new System.Drawing.Point(137, 88);
            this.cmbImpresoraGuia.Name = "cmbImpresoraGuia";
            this.cmbImpresoraGuia.Size = new System.Drawing.Size(207, 21);
            this.cmbImpresoraGuia.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ticket de Pre-Venta:";
            // 
            // cmbImpresoraTicket
            // 
            this.cmbImpresoraTicket.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbImpresoraTicket.FormattingEnabled = true;
            this.cmbImpresoraTicket.Location = new System.Drawing.Point(137, 116);
            this.cmbImpresoraTicket.Name = "cmbImpresoraTicket";
            this.cmbImpresoraTicket.Size = new System.Drawing.Size(207, 21);
            this.cmbImpresoraTicket.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Boleta de Venta:";
            // 
            // cmbImpresoraBoleta
            // 
            this.cmbImpresoraBoleta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbImpresoraBoleta.FormattingEnabled = true;
            this.cmbImpresoraBoleta.Location = new System.Drawing.Point(137, 60);
            this.cmbImpresoraBoleta.Name = "cmbImpresoraBoleta";
            this.cmbImpresoraBoleta.Size = new System.Drawing.Size(207, 21);
            this.cmbImpresoraBoleta.TabIndex = 5;
            // 
            // cmbImpresoraOtrosDocumentos
            // 
            this.cmbImpresoraOtrosDocumentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbImpresoraOtrosDocumentos.FormattingEnabled = true;
            this.cmbImpresoraOtrosDocumentos.Location = new System.Drawing.Point(137, 293);
            this.cmbImpresoraOtrosDocumentos.Name = "cmbImpresoraOtrosDocumentos";
            this.cmbImpresoraOtrosDocumentos.Size = new System.Drawing.Size(207, 21);
            this.cmbImpresoraOtrosDocumentos.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Otros Documentos:";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(303, 354);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmImpresoras
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(396, 389);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGuardar);
            this.MaximizeBox = false;
            this.Name = "frmImpresoras";
            this.ShowIcon = false;
            this.Text = "Impresoras";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmImpresoras_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

    }

    private void cargaPermisos()
    {
      foreach (UsuarioVO usuarioVo in frmMenuPrincipal.listaUsuario)
      {
        if (usuarioVo.Modulo.Equals("IMPRESORA"))
          this._guarda = Convert.ToBoolean(usuarioVo.Guarda);
      }
    }

    private void cargarDatos()
    {
      if (this._guarda)
        this.btnGuardar.Enabled = true;
      else
        this.btnGuardar.Enabled = false;
      try
      {
        DataSet dataSet = new DataSet();
        int num = (int) dataSet.ReadXml("C:\\AptuSoft\\xml\\config.xml");
        this.cmbImpresoraFactura.Text = dataSet.Tables["impresoras"].Rows[0]["factura"].ToString();
        this.cmbImpresoraBoleta.Text = dataSet.Tables["impresoras"].Rows[0]["boleta"].ToString();
        this.cmbImpresoraGuia.Text = dataSet.Tables["impresoras"].Rows[0]["guia"].ToString();
        this.cmbImpresoraTicket.Text = dataSet.Tables["impresoras"].Rows[0]["ticket"].ToString();
        this.cmbImpresoraNotaCredito.Text = dataSet.Tables["impresoras"].Rows[0]["nota_credito"].ToString();
        this.cmbImpresoraCotizacion.Text = dataSet.Tables["impresoras"].Rows[0]["cotizacion"].ToString();
        this.cmbImpresoraNotaVenta.Text = dataSet.Tables["impresoras"].Rows[0]["nota_venta"].ToString();
        this.cmbImpresoraOtrosDocumentos.Text = dataSet.Tables["impresoras"].Rows[0]["otros"].ToString();
        this.cmbImpresoraCodigosBarra.Text = dataSet.Tables["impresoras"].Rows[0]["barcode"].ToString();
        this.cmbComanda.Text = dataSet.Tables["impresoras"].Rows[0]["comanda"].ToString(); 
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("No hay registros, Ingrese Datos " + ex.Message);
        this.creaXML();
      }
    }

    public void cargaComboImpresoras()
    {
      for (int index = 0; index < PrinterSettings.InstalledPrinters.Count; ++index)
      {
        PrinterSettings printerSettings = new PrinterSettings();
        printerSettings.PrinterName = PrinterSettings.InstalledPrinters[index].ToString();
        this.cmbImpresoraFactura.Items.Add((object) printerSettings.PrinterName.ToString());
        this.cmbImpresoraBoleta.Items.Add((object) printerSettings.PrinterName.ToString());
        this.cmbImpresoraGuia.Items.Add((object) printerSettings.PrinterName.ToString());
        this.cmbImpresoraTicket.Items.Add((object) printerSettings.PrinterName.ToString());
        this.cmbImpresoraOtrosDocumentos.Items.Add((object) printerSettings.PrinterName.ToString());
        this.cmbImpresoraCotizacion.Items.Add((object) printerSettings.PrinterName.ToString());
        this.cmbImpresoraNotaVenta.Items.Add((object) printerSettings.PrinterName.ToString());
        this.cmbImpresoraNotaCredito.Items.Add((object) printerSettings.PrinterName.ToString());
        this.cmbImpresoraCodigosBarra.Items.Add((object)printerSettings.PrinterName.ToString());
        this.cmbComanda.Items.Add((object)printerSettings.PrinterName.ToString());
      }
    }

    public string impresoraDefecto()
    {
      for (int index = 0; index < PrinterSettings.InstalledPrinters.Count; ++index)
      {
        if (new PrinterSettings()
        {
          PrinterName = PrinterSettings.InstalledPrinters[index].ToString()
        }.IsDefaultPrinter)
          return PrinterSettings.InstalledPrinters[index].ToString();
      }
      return "";
    }

    private void creaXML()
    {
        respaldo_xml_config rp = new respaldo_xml_config();
        rp.recupera();
    }

    private void btnGuardar_Click_1(object sender, EventArgs e)
    {
      try
      {
        DataSet dataSet = new DataSet();
        int num1 = (int) dataSet.ReadXml("C:\\AptuSoft\\xml\\config.xml");
        dataSet.Tables["impresoras"].Rows[0]["factura"] = (object) this.cmbImpresoraFactura.Text;
        dataSet.Tables["impresoras"].Rows[0]["boleta"] = (object) this.cmbImpresoraBoleta.Text;
        dataSet.Tables["impresoras"].Rows[0]["guia"] = (object) this.cmbImpresoraGuia.Text;
        dataSet.Tables["impresoras"].Rows[0]["ticket"] = (object) this.cmbImpresoraTicket.Text;
        dataSet.Tables["impresoras"].Rows[0]["otros"] = (object)this.cmbImpresoraOtrosDocumentos.Text;
        dataSet.Tables["impresoras"].Rows[0]["barcode"] = (object)this.cmbImpresoraCodigosBarra.Text;
        dataSet.Tables["impresoras"].Rows[0]["cotizacion"] = (object) this.cmbImpresoraCotizacion.Text;
        dataSet.Tables["impresoras"].Rows[0]["nota_credito"] = (object) this.cmbImpresoraNotaCredito.Text;
        dataSet.Tables["impresoras"].Rows[0]["nota_venta"] = (object) this.cmbImpresoraNotaVenta.Text;
        dataSet.Tables["impresoras"].Rows[0]["comanda"] = (object)this.cmbComanda.Text;
        dataSet.WriteXml("C:\\AptuSoft\\xml\\config.xml");
        int num2 = (int) MessageBox.Show("Datos Guardados");
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al Guardar: " + ex.Message);
      }
      respaldo_xml_config rp = new respaldo_xml_config();
      rp.genera_backup();
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
      frmMenuPrincipal._modOpcionesImpresoras = 0;
      this.Close();
    }

    private void frmImpresoras_FormClosing(object sender, FormClosingEventArgs e)
    {
      frmMenuPrincipal._modOpcionesImpresoras = 0;
    }
  }
}
