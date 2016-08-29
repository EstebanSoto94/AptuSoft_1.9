 
// Type: Aptusoft.FacturaElectronica.Formularios.frmIntercambioDeInformacion
 
 
// version 1.8.0

using Aptusoft.FacturaElectronica.Clases;
using Aptusoft.FacturaElectronica.Clases.FirmaTimbreXML;
using Aptusoft.FacturaElectronica.Clases.RespuestaEnviosDte;
using Aptusoft.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Data;
using System.Net.Mail;
using System.Net.Mime;

namespace Aptusoft.FacturaElectronica.Formularios
{
  public class frmIntercambioDeInformacion : Form
  {
    private IContainer components = (IContainer) null;
    private List<csRecepcionEnvioDTE> lista = new List<csRecepcionEnvioDTE>();
    private EmisorVO emi = new EmisorVO();
    private string _rutRecibe = "";
    private string _rutResponde = "";
    private string _rutReceptorObtenidoEnvio = "";
    private string _archivo = "";
    private string _idDte = "";
    private string _digestValue = "";
    private int num=0;
    private DataGridView dgvDatos;
    private Button btnCargaDte;
    private DateTimePicker dtpRecepcionEnvio;
    private Label label1;
    private Panel panelRecepcion;
    private TextBox txtCodigoEnvio;
    private Label label2;
    private Label lblMensaje;
    private Label label3;
    private TextBox txtGlosaEstadoRecepcion;
    private TextBox txtCodigoEstadoRecepcion;
    private GroupBox groupBox1;
    private Button btnSalir;
    private Button btnEnviar;
    private RadioButton rdbAceptacionRechazoDte;
    private RadioButton rdbRecepcionMercaderia;
    private RadioButton rdbAcuseRecibo;
    private ToolTip toolTip1;
    private Label lblRutaArchivo;
    private DataGridViewTextBoxColumn RutEmpresa;
    private DataGridViewTextBoxColumn TipoDte;
    private DataGridViewTextBoxColumn Folio;
    private DataGridViewTextBoxColumn Fecha;
    private DataGridViewTextBoxColumn RutProveedor;
    private DataGridViewTextBoxColumn Proveedor;
    private DataGridViewTextBoxColumn Total;
    private DataGridViewTextBoxColumn Comentario;
    private DataGridViewTextBoxColumn CodigoEstadoRecepcion;
    private DataGridViewTextBoxColumn EstadoDte;
    private DataGridViewTextBoxColumn EstadoDteGlosa;
    private DataGridViewButtonColumn Detalle;
    private frmIntercambioDeInformacion intance;
    private string _rutaElectronica = "";
    string multiEmpresa = new LeeXml().cargarDatosMultiEmpresa("factura")[1].ToString();

    public frmIntercambioDeInformacion()
    {
      this.InitializeComponent();
      this.dgvDatos.AutoGenerateColumns = false;
      this.obtieneDatosEmisor();
      this.iniciaFormulario();
      this.intance = this;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.RutEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Folio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RutProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comentario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoEstadoRecepcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoDte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoDteGlosa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalle = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dtpRecepcionEnvio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panelRecepcion = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGlosaEstadoRecepcion = new System.Windows.Forms.TextBox();
            this.txtCodigoEstadoRecepcion = new System.Windows.Forms.TextBox();
            this.txtCodigoEnvio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.rdbAceptacionRechazoDte = new System.Windows.Forms.RadioButton();
            this.rdbRecepcionMercaderia = new System.Windows.Forms.RadioButton();
            this.rdbAcuseRecibo = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCargaDte = new System.Windows.Forms.Button();
            this.lblRutaArchivo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.panelRecepcion.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender;
            this.dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDatos.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RutEmpresa,
            this.TipoDte,
            this.Folio,
            this.Fecha,
            this.RutProveedor,
            this.Proveedor,
            this.Total,
            this.Comentario,
            this.CodigoEstadoRecepcion,
            this.EstadoDte,
            this.EstadoDteGlosa,
            this.Detalle});
            this.dgvDatos.Location = new System.Drawing.Point(4, 100);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersVisible = false;
            this.dgvDatos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(1111, 175);
            this.dgvDatos.TabIndex = 0;
            this.dgvDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellClick);
            // 
            // RutEmpresa
            // 
            this.RutEmpresa.DataPropertyName = "RUTRecep";
            this.RutEmpresa.HeaderText = "Rut Receptor";
            this.RutEmpresa.Name = "RutEmpresa";
            this.RutEmpresa.ReadOnly = true;
            this.RutEmpresa.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // TipoDte
            // 
            this.TipoDte.DataPropertyName = "TipoDTE";
            this.TipoDte.HeaderText = "Tipo";
            this.TipoDte.Name = "TipoDte";
            this.TipoDte.ReadOnly = true;
            this.TipoDte.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TipoDte.Width = 60;
            // 
            // Folio
            // 
            this.Folio.DataPropertyName = "Folio";
            this.Folio.HeaderText = "Folio";
            this.Folio.Name = "Folio";
            this.Folio.ReadOnly = true;
            this.Folio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Folio.Width = 80;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "FchEmis";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // RutProveedor
            // 
            this.RutProveedor.DataPropertyName = "RUTEmisor";
            this.RutProveedor.HeaderText = "Rut Emisor";
            this.RutProveedor.Name = "RutProveedor";
            this.RutProveedor.ReadOnly = true;
            this.RutProveedor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Proveedor
            // 
            this.Proveedor.DataPropertyName = "RazonSocial";
            this.Proveedor.HeaderText = "Emisor - Proveedor";
            this.Proveedor.Name = "Proveedor";
            this.Proveedor.ReadOnly = true;
            this.Proveedor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Proveedor.Width = 250;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "MntTotal";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = "0";
            this.Total.DefaultCellStyle = dataGridViewCellStyle2;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Comentario
            // 
            this.Comentario.DataPropertyName = "RecepDTEGlosa";
            this.Comentario.HeaderText = "Estado Recepción";
            this.Comentario.Name = "Comentario";
            this.Comentario.ReadOnly = true;
            this.Comentario.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Comentario.Visible = false;
            this.Comentario.Width = 220;
            // 
            // CodigoEstadoRecepcion
            // 
            this.CodigoEstadoRecepcion.DataPropertyName = "EstadoRecepDTE";
            this.CodigoEstadoRecepcion.HeaderText = "CodigoEstadoRecepcion";
            this.CodigoEstadoRecepcion.Name = "CodigoEstadoRecepcion";
            this.CodigoEstadoRecepcion.ReadOnly = true;
            this.CodigoEstadoRecepcion.Visible = false;
            // 
            // EstadoDte
            // 
            this.EstadoDte.DataPropertyName = "EstadoDTE";
            this.EstadoDte.HeaderText = "EstadoDte";
            this.EstadoDte.Name = "EstadoDte";
            this.EstadoDte.ReadOnly = true;
            this.EstadoDte.Width = 60;
            // 
            // EstadoDteGlosa
            // 
            this.EstadoDteGlosa.DataPropertyName = "EstadoDTEGlosa";
            this.EstadoDteGlosa.HeaderText = "EstadoDteGlosa";
            this.EstadoDteGlosa.Name = "EstadoDteGlosa";
            this.EstadoDteGlosa.ReadOnly = true;
            this.EstadoDteGlosa.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.EstadoDteGlosa.Width = 170;
            // 
            // Detalle
            // 
            this.Detalle.HeaderText = "Detalle";
            this.Detalle.Name = "Detalle";
            this.Detalle.ReadOnly = true;
            this.Detalle.Text = "Detalle";
            this.Detalle.UseColumnTextForButtonValue = true;
            this.Detalle.Width = 80;
            // 
            // dtpRecepcionEnvio
            // 
            this.dtpRecepcionEnvio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRecepcionEnvio.Location = new System.Drawing.Point(158, 10);
            this.dtpRecepcionEnvio.Name = "dtpRecepcionEnvio";
            this.dtpRecepcionEnvio.Size = new System.Drawing.Size(91, 20);
            this.dtpRecepcionEnvio.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fecha de Recepción";
            // 
            // panelRecepcion
            // 
            this.panelRecepcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.panelRecepcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRecepcion.Controls.Add(this.label3);
            this.panelRecepcion.Controls.Add(this.txtGlosaEstadoRecepcion);
            this.panelRecepcion.Controls.Add(this.txtCodigoEstadoRecepcion);
            this.panelRecepcion.Controls.Add(this.txtCodigoEnvio);
            this.panelRecepcion.Controls.Add(this.label2);
            this.panelRecepcion.Controls.Add(this.label1);
            this.panelRecepcion.Controls.Add(this.dtpRecepcionEnvio);
            this.panelRecepcion.Location = new System.Drawing.Point(104, 9);
            this.panelRecepcion.Name = "panelRecepcion";
            this.panelRecepcion.Size = new System.Drawing.Size(518, 85);
            this.panelRecepcion.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Estado Recepción Envio";
            // 
            // txtGlosaEstadoRecepcion
            // 
            this.txtGlosaEstadoRecepcion.BackColor = System.Drawing.Color.White;
            this.txtGlosaEstadoRecepcion.Location = new System.Drawing.Point(193, 38);
            this.txtGlosaEstadoRecepcion.Name = "txtGlosaEstadoRecepcion";
            this.txtGlosaEstadoRecepcion.ReadOnly = true;
            this.txtGlosaEstadoRecepcion.Size = new System.Drawing.Size(314, 20);
            this.txtGlosaEstadoRecepcion.TabIndex = 8;
            // 
            // txtCodigoEstadoRecepcion
            // 
            this.txtCodigoEstadoRecepcion.BackColor = System.Drawing.Color.White;
            this.txtCodigoEstadoRecepcion.Location = new System.Drawing.Point(158, 38);
            this.txtCodigoEstadoRecepcion.Name = "txtCodigoEstadoRecepcion";
            this.txtCodigoEstadoRecepcion.ReadOnly = true;
            this.txtCodigoEstadoRecepcion.Size = new System.Drawing.Size(30, 20);
            this.txtCodigoEstadoRecepcion.TabIndex = 7;
            // 
            // txtCodigoEnvio
            // 
            this.txtCodigoEnvio.Location = new System.Drawing.Point(447, 10);
            this.txtCodigoEnvio.Name = "txtCodigoEnvio";
            this.txtCodigoEnvio.Size = new System.Drawing.Size(60, 20);
            this.txtCodigoEnvio.TabIndex = 6;
            this.txtCodigoEnvio.Text = "1234";
            this.txtCodigoEnvio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodigoEnvio.Visible = false;
            this.txtCodigoEnvio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoEnvio_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cod. Envio";
            this.label2.Visible = false;
            // 
            // lblMensaje
            // 
            this.lblMensaje.BackColor = System.Drawing.Color.White;
            this.lblMensaje.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(4, 281);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(507, 80);
            this.lblMensaje.TabIndex = 6;
            this.lblMensaje.Text = "....";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEnviar);
            this.groupBox1.Controls.Add(this.rdbAceptacionRechazoDte);
            this.groupBox1.Controls.Add(this.rdbRecepcionMercaderia);
            this.groupBox1.Controls.Add(this.rdbAcuseRecibo);
            this.groupBox1.Location = new System.Drawing.Point(628, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 85);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Respuestas a Proveedor";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Image = global::Aptusoft.Properties.Resources.send_mail_icone_9097_48;
            this.btnEnviar.Location = new System.Drawing.Point(393, 13);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(87, 66);
            this.btnEnviar.TabIndex = 3;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEnviar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // rdbAceptacionRechazoDte
            // 
            this.rdbAceptacionRechazoDte.AutoSize = true;
            this.rdbAceptacionRechazoDte.Location = new System.Drawing.Point(17, 61);
            this.rdbAceptacionRechazoDte.Name = "rdbAceptacionRechazoDte";
            this.rdbAceptacionRechazoDte.Size = new System.Drawing.Size(190, 17);
            this.rdbAceptacionRechazoDte.TabIndex = 2;
            this.rdbAceptacionRechazoDte.TabStop = true;
            this.rdbAceptacionRechazoDte.Text = "Aceptacion o Rechazo de los DTE";
            this.toolTip1.SetToolTip(this.rdbAceptacionRechazoDte, "Permite aceptar o rechazar los dte recibidos");
            this.rdbAceptacionRechazoDte.UseVisualStyleBackColor = true;
            // 
            // rdbRecepcionMercaderia
            // 
            this.rdbRecepcionMercaderia.AutoSize = true;
            this.rdbRecepcionMercaderia.Location = new System.Drawing.Point(17, 40);
            this.rdbRecepcionMercaderia.Name = "rdbRecepcionMercaderia";
            this.rdbRecepcionMercaderia.Size = new System.Drawing.Size(180, 17);
            this.rdbRecepcionMercaderia.TabIndex = 1;
            this.rdbRecepcionMercaderia.TabStop = true;
            this.rdbRecepcionMercaderia.Text = "Recibo de Mercaderia o Servicio";
            this.toolTip1.SetToolTip(this.rdbRecepcionMercaderia, "Acepta conforme la mercaderia recibida");
            this.rdbRecepcionMercaderia.UseVisualStyleBackColor = true;
            // 
            // rdbAcuseRecibo
            // 
            this.rdbAcuseRecibo.AutoSize = true;
            this.rdbAcuseRecibo.Location = new System.Drawing.Point(17, 19);
            this.rdbAcuseRecibo.Name = "rdbAcuseRecibo";
            this.rdbAcuseRecibo.Size = new System.Drawing.Size(107, 17);
            this.rdbAcuseRecibo.TabIndex = 0;
            this.rdbAcuseRecibo.TabStop = true;
            this.rdbAcuseRecibo.Text = "Acuse de Recibo";
            this.toolTip1.SetToolTip(this.rdbAcuseRecibo, "Respuesta de Recepcion correcta del archivo");
            this.rdbAcuseRecibo.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = global::Aptusoft.Properties.Resources.salir_de_mi_perfil_icono_3964_48;
            this.btnSalir.Location = new System.Drawing.Point(1021, 278);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(94, 85);
            this.btnSalir.TabIndex = 24;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCargaDte
            // 
            this.btnCargaDte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargaDte.Image = global::Aptusoft.Properties.Resources.de_busqueda_de_archivos_encontrar_vista_del_documento_icono_8728_48;
            this.btnCargaDte.Location = new System.Drawing.Point(4, 9);
            this.btnCargaDte.Name = "btnCargaDte";
            this.btnCargaDte.Size = new System.Drawing.Size(94, 85);
            this.btnCargaDte.TabIndex = 1;
            this.btnCargaDte.Text = "Buscar DTE";
            this.btnCargaDte.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCargaDte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCargaDte.UseVisualStyleBackColor = true;
            this.btnCargaDte.Click += new System.EventHandler(this.btnCargaDte_Click);
            // 
            // lblRutaArchivo
            // 
            this.lblRutaArchivo.AutoSize = true;
            this.lblRutaArchivo.Location = new System.Drawing.Point(7, 370);
            this.lblRutaArchivo.Name = "lblRutaArchivo";
            this.lblRutaArchivo.Size = new System.Drawing.Size(10, 13);
            this.lblRutaArchivo.TabIndex = 25;
            this.lblRutaArchivo.Text = ".";
            // 
            // frmIntercambioDeInformacion
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1120, 388);
            this.Controls.Add(this.lblRutaArchivo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.panelRecepcion);
            this.Controls.Add(this.btnCargaDte);
            this.Controls.Add(this.dgvDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmIntercambioDeInformacion";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Intercambio De Informacion";
            this.Load += new System.EventHandler(this.frmIntercambioDeInformacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.panelRecepcion.ResumeLayout(false);
            this.panelRecepcion.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private void iniciaFormulario()
    {
      this._rutRecibe = string.Empty;
      this._rutResponde = string.Empty;
      this._rutReceptorObtenidoEnvio = string.Empty;
      this._archivo = string.Empty;
      this._idDte = string.Empty;
      this._digestValue = string.Empty;
      this.panelRecepcion.Enabled = false;
      this.txtCodigoEstadoRecepcion.Text = "";
      this.txtGlosaEstadoRecepcion.Text = "";
      this.lblMensaje.Text = "...";
      this.lista.Clear();
      this.dgvDatos.DataSource = (object) null;
      this.rdbAcuseRecibo.Checked = true;
      this.rdbRecepcionMercaderia.Checked = false;
      this.rdbAceptacionRechazoDte.Checked = false;
    }

    private void obtieneDatosEmisor()
    {
      this.emi = new Emisor().buscaEmisor();
    }

    private void btnCargaDte_Click(object sender, EventArgs e)
    {
      this.iniciaFormulario();
      try
      {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = "Archivos XML(*.xml)| *.xml";
        openFileDialog.InitialDirectory = @"C:\Aptusoft\";
        if (openFileDialog.ShowDialog() != DialogResult.OK)
          return;
        string fileName = openFileDialog.FileName;
        this.lblRutaArchivo.Text = fileName;
        this._archivo = openFileDialog.SafeFileName;
        XDocument xdocument = XDocument.Load(fileName, LoadOptions.PreserveWhitespace);
        XmlNamespaceManager namespaceManager = new XmlNamespaceManager((XmlNameTable) new NameTable());
        namespaceManager.AddNamespace("sii", "http://www.sii.cl/SiiDte");
        foreach (XElement xelement in Enumerable.Select<XElement, XElement>(frmIntercambioDeInformacion.RemoveAllNamespaces(System.Xml.XPath.Extensions.XPathSelectElement((XNode) xdocument, "sii:EnvioDTE", (IXmlNamespaceResolver) namespaceManager)).Elements(), (Func<XElement, XElement>) (el => el)))
        {
          if (System.Xml.XPath.Extensions.XPathSelectElement((XNode) xelement, "SignedInfo/Reference/DigestValue") != null)
            this._digestValue = System.Xml.XPath.Extensions.XPathSelectElement((XNode) xelement, "SignedInfo/Reference/DigestValue").Value;
        }
        XElement xmlDocument = System.Xml.XPath.Extensions.XPathSelectElement((XNode) xdocument, "sii:EnvioDTE/sii:SetDTE", (IXmlNamespaceResolver) namespaceManager);
        this._idDte = xmlDocument.Attribute((XName) "ID").Value;
        XElement xelement1 = frmIntercambioDeInformacion.RemoveAllNamespaces(xmlDocument);
        this.lista = new List<csRecepcionEnvioDTE>();
        csRecepcionEnvioDTE recepcionEnvioDte1 = new csRecepcionEnvioDTE();
        foreach (XElement xelement2 in Enumerable.Select<XElement, XElement>(xelement1.Elements(), (Func<XElement, XElement>) (el => el)))
        {
          csRecepcionEnvioDTE recepcionEnvioDte2 = (csRecepcionEnvioDTE) null;
          if (System.Xml.XPath.Extensions.XPathSelectElement((XNode) xelement2, "RutReceptor") != null)
            this._rutReceptorObtenidoEnvio = System.Xml.XPath.Extensions.XPathSelectElement((XNode) xelement2, "RutReceptor").Value;
          if (System.Xml.XPath.Extensions.XPathSelectElement((XNode) xelement2, "Documento/Encabezado/IdDoc/TipoDTE") != null)
          {
            XElement xelement3 = System.Xml.XPath.Extensions.XPathSelectElement((XNode) xelement2, "Documento/Encabezado/IdDoc/TipoDTE");
            recepcionEnvioDte2 = new csRecepcionEnvioDTE();
            recepcionEnvioDte2.TipoDTE = xelement3.Value;
          }
          if (System.Xml.XPath.Extensions.XPathSelectElement((XNode) xelement2, "Documento/Encabezado/IdDoc/Folio") != null)
          {
            XElement xelement3 = System.Xml.XPath.Extensions.XPathSelectElement((XNode) xelement2, "Documento/Encabezado/IdDoc/Folio");
            recepcionEnvioDte2.Folio = xelement3.Value;
          }
          if (System.Xml.XPath.Extensions.XPathSelectElement((XNode) xelement2, "Documento/Encabezado/IdDoc/FchEmis") != null)
          {
            XElement xelement3 = System.Xml.XPath.Extensions.XPathSelectElement((XNode) xelement2, "Documento/Encabezado/IdDoc/FchEmis");
            recepcionEnvioDte2.FchEmis = Convert.ToDateTime(xelement3.Value);
          }
          if (System.Xml.XPath.Extensions.XPathSelectElement((XNode) xelement2, "Documento/Encabezado/Emisor/RUTEmisor") != null)
          {
            XElement xelement3 = System.Xml.XPath.Extensions.XPathSelectElement((XNode) xelement2, "Documento/Encabezado/Emisor/RUTEmisor");
            recepcionEnvioDte2.RUTEmisor = xelement3.Value;
          }
          if (System.Xml.XPath.Extensions.XPathSelectElement((XNode) xelement2, "Documento/Encabezado/Receptor/RUTRecep") != null)
          {
            XElement xelement3 = System.Xml.XPath.Extensions.XPathSelectElement((XNode) xelement2, "Documento/Encabezado/Receptor/RUTRecep");
            recepcionEnvioDte2.RUTRecep = xelement3.Value;
          }
          if (System.Xml.XPath.Extensions.XPathSelectElement((XNode) xelement2, "Documento/Encabezado/Emisor/RznSoc") != null)
          {
            XElement xelement3 = System.Xml.XPath.Extensions.XPathSelectElement((XNode) xelement2, "Documento/Encabezado/Emisor/RznSoc");
            recepcionEnvioDte2.RazonSocial = xelement3.Value;
          }
          if (System.Xml.XPath.Extensions.XPathSelectElement((XNode) xelement2, "Documento/Encabezado/Totales/MntTotal") != null)
          {
            XElement xelement3 = System.Xml.XPath.Extensions.XPathSelectElement((XNode) xelement2, "Documento/Encabezado/Totales/MntTotal");
            recepcionEnvioDte2.MntTotal = xelement3.Value;
          }
          if (recepcionEnvioDte2 != null)
            this.lista.Add(recepcionEnvioDte2);
        }
        if (this.lista.Count > 0)
        {
          this.dgvDatos.DataSource = (object) null;
          this.dgvDatos.DataSource = (object) this.lista;
          this.validaciones(fileName);
          this.validaGrilla();
          this.panelRecepcion.Enabled = true;
        }
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error " + ex.Message);
      }
    }

    private static XElement RemoveAllNamespaces(XElement xmlDocument)
    {
      if (xmlDocument.HasElements)
        return new XElement((XName) xmlDocument.Name.LocalName, (object) Enumerable.Select<XElement, XElement>(xmlDocument.Elements(), (Func<XElement, XElement>) (el => frmIntercambioDeInformacion.RemoveAllNamespaces(el))));
      XElement xelement = new XElement((XName) xmlDocument.Name.LocalName);
      xelement.Value = xmlDocument.Value;
      foreach (XAttribute xattribute in xmlDocument.Attributes())
        xelement.Add((object) xattribute);
      return xelement;
    }

    public static string RemoveAllNamespaces(string xmlDocument)
    {
      return frmIntercambioDeInformacion.RemoveAllNamespaces(XElement.Parse(xmlDocument)).ToString();
    }

    private void button1_Click(object sender, EventArgs e)
    {
    }

    private void obtieneDatosGrilla()
    {
      foreach (csRecepcionEnvioDTE recepcionEnvioDte in this.lista)
        this._rutRecibe = recepcionEnvioDte.RUTEmisor;
    }

    private void soloNumeros(KeyPressEventArgs e)
    {
      string str = "0123456789";
      if ((int) e.KeyChar == 46)
        e.KeyChar = ',';
      if (str.Contains(string.Concat((object) e.KeyChar)) || (int) e.KeyChar == 8)
        e.Handled = false;
      else
        e.Handled = true;
    }

    private void validaGrilla()
    {
      foreach (DataGridViewRow dataGridViewRow in (IEnumerable) this.dgvDatos.Rows)
      {
        bool flag = true;
        int index = dataGridViewRow.Index;
        if (!this.emi.RutEmisior.Equals(dataGridViewRow.Cells["RutEmpresa"].Value.ToString()))
        {
          this.dgvDatos.Rows[index].Cells[0].Style.BackColor = Color.LightSalmon;
          this.dgvDatos.Rows[index].Cells[1].Style.BackColor = Color.LightSalmon;
          this.dgvDatos.Rows[index].Cells[2].Style.BackColor = Color.LightSalmon;
          this.dgvDatos.Rows[index].Cells[3].Style.BackColor = Color.LightSalmon;
          this.dgvDatos.Rows[index].Cells[4].Style.BackColor = Color.LightSalmon;
          this.dgvDatos.Rows[index].Cells[5].Style.BackColor = Color.LightSalmon;
          this.dgvDatos.Rows[index].Cells[6].Style.BackColor = Color.LightSalmon;
          this.dgvDatos.Rows[index].Cells[7].Style.BackColor = Color.LightSalmon;
          this.dgvDatos.Rows[index].Cells[7].Value = (object) "DTE No Recibido - Error en Rut Receptor";
          this.dgvDatos.Rows[index].Cells[8].Value = (object) "3";
          this.dgvDatos.Rows[index].Cells[9].Value = (object) "2";
          this.dgvDatos.Rows[index].Cells[10].Value = (object) "DTE Rechazado";
          flag = false;
        }
        if (flag)
        {
          this.dgvDatos.Rows[index].Cells[7].Value = (object) "DTE Recibido OK";
          this.dgvDatos.Rows[index].Cells[8].Value = (object) "0";
          this.dgvDatos.Rows[index].Cells[9].Value = (object) "0";
          this.dgvDatos.Rows[index].Cells[10].Value = (object) "DTE Aceptado OK";
        }
      }
    }

    private void frmIntercambioDeInformacion_Load(object sender, EventArgs e)
    {
    }

    private void txtCodigoEnvio_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e);
    }

    private void validaciones(string dte)
    {
      bool flag = this.validaSchema(dte);
      if (flag)
        flag = this.validaRutReceptor();
      if (!flag)
        return;
      this.txtCodigoEstadoRecepcion.Text = "0";
      this.txtGlosaEstadoRecepcion.Text = "Envio Recibido Conforme";
    }

    private bool validaSchema(string dte)
    {
      bool continuar = true;
      string uriSchema = "C:\\AptuSoft\\Electronica\\Archivos\\Schemas\\EnvioDTE_v10.xsd";
      new List<string>().Clear();
      List<string> list = FuncionesComunes.ValidarSchema(dte, uriSchema);
      if (list.Count > 0)
      {
        string er = "";
        list.ForEach((Action<string>) (es =>
        {
         //CORREGIR URGENTE ! 
          //frmIntercambioDeInformacion.\u003C\u003Ec__DisplayClass9 cDisplayClass9 = this;
          
          //string str = cDisplayClass9.er + es + "\r\n";
          
         // cDisplayClass9.er = str;
          continuar = false;
        }));
        this.lblMensaje.Text = "Envio Rechazado - Error de Schema\r\n" + er;
        this.txtCodigoEstadoRecepcion.Text = "1";
        this.txtGlosaEstadoRecepcion.Text = "Envio Rechazado - Error de Schema";
      }
      return continuar;
    }

    private bool validaFirma(string dte)
    {
      if (new csComprobarFirma().comprobarFirma(dte))
      {
        int num = (int) MessageBox.Show("firma correcta");
        return true;
      }
      int num1 = (int) MessageBox.Show("firma NO ES correcta");
      return false;
    }

    private bool validaRutReceptor()
    {
      bool flag = true;
      if (this._rutReceptorObtenidoEnvio != this.emi.RutEmisior)
      {
        this.lblMensaje.Text = "Envio Rechazado - Rut Receptor No Corresponde";
        this.txtCodigoEstadoRecepcion.Text = "3";
        this.txtGlosaEstadoRecepcion.Text = "Envio Rechazado - Rut Receptor No Corresponde";
        flag = false;
      }
      return flag;
    }

    private void btnResultadoAprobacion_Click(object sender, EventArgs e)
    {
      this.obtieneDatosGrilla();
      csGeneraXMLRespuesta generaXmlRespuesta = new csGeneraXMLRespuesta();
      this._rutResponde = this.emi.RutEmisior;
      csRespuestaVO reVO = new csRespuestaVO();
      reVO.RutRecibe = this._rutRecibe;
      reVO.RutResponde = this._rutResponde;
      reVO.Archivo = this._archivo;
      reVO.FechaRecepcionEnvio = this.dtpRecepcionEnvio.Value;
      reVO.CodigoEnvio = this.txtCodigoEnvio.Text.Trim();
      reVO.IdDte = this._idDte;
      reVO.DigestValue = this._digestValue;
      reVO.CodigoEstadoRecepcion = this.txtCodigoEstadoRecepcion.Text.Trim();
      reVO.GlosaEstadoRecepcion = this.txtGlosaEstadoRecepcion.Text.Trim();
      reVO.NroDte = this.lista.Count.ToString();
      foreach (csRecepcionEnvioDTE recepcionEnvioDte in this.lista)
      {
        if (recepcionEnvioDte.EstadoRecepDTE.Equals("0"))
          recepcionEnvioDte.RecepDTEGlosa = "DTE Aceptado OK";
        if (recepcionEnvioDte.EstadoRecepDTE.Equals("0"))
          recepcionEnvioDte.RecepDTEGlosa = "DTE Aceptado OK";
        if (recepcionEnvioDte.EstadoRecepDTE.Equals("3"))
        {
          recepcionEnvioDte.EstadoRecepDTE = "2";
          recepcionEnvioDte.RecepDTEGlosa = "DTE Rechazado";
        }
      }
      generaXmlRespuesta.creaXMLRespuesta(reVO, this.lista, "RESULTADO_APROBACION");
      int num = (int) MessageBox.Show("Archivo XML Creado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }

    private void btnReciboMercaderia_Click(object sender, EventArgs e)
    {
      this.obtieneDatosGrilla();
      csGeneraXMLRespuesta generaXmlRespuesta = new csGeneraXMLRespuesta();
      this._rutResponde = this.emi.RutEmisior;
      generaXmlRespuesta.creaXMLEnvioRecibo(new csRespuestaVO()
      {
        RutRecibe = this._rutRecibe,
        RutResponde = this._rutResponde,
        Archivo = this._archivo,
        FechaRecepcionEnvio = this.dtpRecepcionEnvio.Value,
        CodigoEnvio = this.txtCodigoEnvio.Text.Trim(),
        IdDte = this._idDte,
        DigestValue = this._digestValue,
        CodigoEstadoRecepcion = this.txtCodigoEstadoRecepcion.Text.Trim(),
        GlosaEstadoRecepcion = this.txtGlosaEstadoRecepcion.Text.Trim(),
        NroDte = this.lista.Count.ToString()
      }, this.lista);
      int num = (int) MessageBox.Show("Archivo XML Creado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void acuseRecibo()
    {
      this.obtieneDatosGrilla();
      csGeneraXMLRespuesta generaXmlRespuesta = new csGeneraXMLRespuesta();
      this._rutResponde = this.emi.RutEmisior;
      generaXmlRespuesta.creaXMLRespuesta(new csRespuestaVO()
      {
        RutRecibe = this._rutRecibe,
        RutResponde = this._rutResponde,
        Archivo = this._archivo,
        FechaRecepcionEnvio = this.dtpRecepcionEnvio.Value,
        CodigoEnvio = this.txtCodigoEnvio.Text.Trim(),
        IdDte = this._idDte,
        DigestValue = this._digestValue,
        CodigoEstadoRecepcion = this.txtCodigoEstadoRecepcion.Text.Trim(),
        GlosaEstadoRecepcion = this.txtGlosaEstadoRecepcion.Text.Trim(),
        NroDte = this.lista.Count.ToString()
      }, this.lista, "ACUSE_RECIBO");
      int num = (int) MessageBox.Show("Archivo XML Creado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }

    private void reciboMercaderia()
    {
      this.obtieneDatosGrilla();
      csGeneraXMLRespuesta generaXmlRespuesta = new csGeneraXMLRespuesta();
      this._rutResponde = this.emi.RutEmisior;
      generaXmlRespuesta.creaXMLEnvioRecibo(new csRespuestaVO()
      {
        RutRecibe = this._rutRecibe,
        RutResponde = this._rutResponde,
        Archivo = this._archivo,
        FechaRecepcionEnvio = this.dtpRecepcionEnvio.Value,
        CodigoEnvio = this.txtCodigoEnvio.Text.Trim(),
        IdDte = this._idDte,
        DigestValue = this._digestValue,
        CodigoEstadoRecepcion = this.txtCodigoEstadoRecepcion.Text.Trim(),
        GlosaEstadoRecepcion = this.txtGlosaEstadoRecepcion.Text.Trim(),
        NroDte = this.lista.Count.ToString()
      }, this.lista);
      int num = (int) MessageBox.Show("Archivo XML Creado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }

    private void aceptacionRechazoDte()
    {
      this.obtieneDatosGrilla();
      csGeneraXMLRespuesta generaXmlRespuesta = new csGeneraXMLRespuesta();
      this._rutResponde = this.emi.RutEmisior;
      generaXmlRespuesta.creaXMLRespuesta(new csRespuestaVO()
      {
        RutRecibe = this._rutRecibe,
        RutResponde = this._rutResponde,
        Archivo = this._archivo,
        FechaRecepcionEnvio = this.dtpRecepcionEnvio.Value,
        CodigoEnvio = this.txtCodigoEnvio.Text.Trim(),
        IdDte = this._idDte,
        DigestValue = this._digestValue,
        CodigoEstadoRecepcion = this.txtCodigoEstadoRecepcion.Text.Trim(),
        GlosaEstadoRecepcion = this.txtGlosaEstadoRecepcion.Text.Trim(),
        NroDte = this.lista.Count.ToString()
      }, this.lista, "RESULTADO_APROBACION");
      int num = (int) MessageBox.Show("Archivo XML Creado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }

    private void btnEnviar_Click(object sender, EventArgs e)
    {
      if (this.dgvDatos.RowCount > 0)
      {
          if (this.rdbAcuseRecibo.Checked)
          {
              this.acuseRecibo();
              num = 1;
              //envio();
          }
          if (this.rdbRecepcionMercaderia.Checked)
          {
              this.reciboMercaderia();
              num = 2;
              //envio();
          }
          if (this.rdbAceptacionRechazoDte.Checked)
          {
              this.aceptacionRechazoDte();
              num = 3;
              //envio();
          }
        
      }
      else
      {
        int num = (int) MessageBox.Show("No Hay DTES en la grilla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        try
        {
            if (!(this.dgvDatos.Columns[e.ColumnIndex].Name == "Detalle"))
                return;
            int num = (int)new frmIntercambioDetalle(ref this.intance, this.dgvDatos.SelectedRows[0].Cells["Folio"].Value.ToString(), this.lblRutaArchivo.Text, this.dgvDatos.SelectedRows[0].Cells["EstadoDte"].Value.ToString(), this.dgvDatos.SelectedRows[0].Cells["comentario"].Value.ToString()).ShowDialog();
        }
        catch (Exception ex)
        {
           
        }
    }

    public void cambiaEstadoDteGrilla(string estado, string glosa, string folio)
    {
      foreach (csRecepcionEnvioDTE recepcionEnvioDte in this.lista)
      {
        if (recepcionEnvioDte.Folio.Equals(folio))
        {
          recepcionEnvioDte.EstadoDTE = estado;
          recepcionEnvioDte.EstadoDTEGlosa = glosa;
          break;
        }
      }
      this.dgvDatos.DataSource = (object) null;
      this.dgvDatos.DataSource = (object) this.lista;
    }

    private void CargaRuta()
    {
        try
        {
            DataSet dataSet = new DataSet("datos");
            int num = (int)dataSet.ReadXml(@"C:\AptuSoft\xml\config.xml");
            string filterExpression = "principal=1";
            DataRow[] dataRowArray = dataSet.Tables["conexion"].Select(filterExpression);
            string str = "";
            for (int index = 0; index < dataRowArray.Length; ++index)
                str = dataRowArray[index]["rutaElectronica"].ToString();
            this._rutaElectronica = str.Replace("\\", "\\\\") + "\\\\";
        }
        catch (Exception ex)
        {
            int num = (int)MessageBox.Show("Error al Cargar Ruta " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
    }

    private void envio()
    {
        string str3 = DateTime.Now.ToShortDateString().Replace("/", "").Replace(":", "").Replace("-", "");
        string str = new LeeXml().cargarDatosMultiEmpresa("factura")[1].ToString();
        CargaRuta();
        string ruta_xml = "";
        if (num == 1)
        {
            ruta_xml = this._rutaElectronica + @"RESPUESTAS\1_ACUSE_RECIBO\acuse_recibo_" + _rutRecibe + "_" + multiEmpresa + "_" + str3 + ".XML";
        }
        else if (num == 3)
        {
            ruta_xml = this._rutaElectronica + @"RESPUESTAS\3_RESULTADO\resultado_" + _rutRecibe + "_" + multiEmpresa + "_" + str3 + ".XML";
        }
        else
        {
            ruta_xml = this._rutaElectronica + @"RESPUESTAS\2_RECIBO_MERCADERIA\reciboMercaderia_" + _rutRecibe + "_" + multiEmpresa + "_" + str3 + ".XML";
        }
        Attachment xml;
        xml = new Attachment(ruta_xml, MediaTypeNames.Application.Octet);

        new Correo(xml, ruta_xml, num, _rutRecibe).ShowDialog();
        num = 0;

    } 
  }
}
 