 
// Type: Aptusoft.FacturaElectronica.Formularios.frmIntercambioDetalle
 
 
// version 1.8.0

using Aptusoft;
using Aptusoft.FacturaElectronica.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Aptusoft.FacturaElectronica.Formularios
{
  public class frmIntercambioDetalle : Form
  {
    private frmIntercambioDeInformacion frmIntercambio = (frmIntercambioDeInformacion) null;
    private IContainer components = (IContainer) null;
    private Panel panel1;
    private DataGridView dgvDatos;
    private Panel panel2;
    private TextBox txtExento;
    private TextBox txtTotal;
    private TextBox txtNeto;
    private TextBox txtIva;
    private Label label5;
    private Label label6;
    private Label label8;
    private Label label7;
    private TextBox txtProveedor;
    private TextBox txtTipoDocumento;
    private TextBox txtRut;
    private TextBox txtFolio;
    private TextBox txtEmision;
    private Label label3;
    private Label label1;
    private Label label4;
    private Panel panel3;
    private Label label11;
    private TextBox txtCliente;
    private TextBox txtRutCliente;
    private Label label12;
    private DataGridViewTextBoxColumn Codigo;
    private DataGridViewTextBoxColumn Descripcion;
    private DataGridViewTextBoxColumn Precio;
    private DataGridViewTextBoxColumn Cantidad;
    private DataGridViewTextBoxColumn Total;
    private Label label13;
    private TextBox txtDescuento;
    private TabControl tabControl1;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private Label label2;
    private Panel panel4;
    private Label label9;
    private ComboBox cmbAprobacion;
    private Label lblAlerta;
    private Button btnGuardarEstado;

    public frmIntercambioDetalle(ref frmIntercambioDeInformacion i, string folio, string rutaDte, string estado, string comentario)
    {
      this.InitializeComponent();
      this.dgvDatos.AutoGenerateColumns = false;
      this.iniciaFormulario();
      this.buscaDTE(folio, rutaDte);
      this.seleccionaEstado(estado, comentario);
      this.frmIntercambio = i;
    }

    private void seleccionaEstado(string estado, string comentario)
    {
      if (estado.Equals("0"))
        this.cmbAprobacion.SelectedIndex = 0;
      if (estado.Equals("1"))
        this.cmbAprobacion.SelectedIndex = 1;
      if (estado.Equals("2"))
        this.cmbAprobacion.SelectedIndex = 2;
      this.lblAlerta.Text = comentario;
    }

    private void iniciaFormulario()
    {
      this.txtEmision.Clear();
      this.txtTipoDocumento.Clear();
      this.txtFolio.Clear();
      this.txtRut.Clear();
      this.txtProveedor.Clear();
      this.txtRutCliente.Clear();
      this.txtCliente.Clear();
      this.txtDescuento.Clear();
      this.txtExento.Clear();
      this.txtNeto.Clear();
      this.txtIva.Clear();
      this.txtTotal.Clear();
    }

    private void buscaDTE(string folio, string rutaDte)
    {
      XDocument xdocument = XDocument.Load(rutaDte, LoadOptions.PreserveWhitespace);
      XmlNamespaceManager namespaceManager = new XmlNamespaceManager((XmlNameTable) new NameTable());
      namespaceManager.AddNamespace("sii", "http://www.sii.cl/SiiDte");
      XElement xelement1 = frmIntercambioDetalle.RemoveAllNamespaces(System.Xml.XPath.Extensions.XPathSelectElement((XNode) xdocument, "sii:EnvioDTE/sii:SetDTE", (IXmlNamespaceResolver) namespaceManager));
      csRecepcionEnvioDTE recepcionEnvioDte = new csRecepcionEnvioDTE();
      List<DatosVentaVO> list = new List<DatosVentaVO>();
      DatosVentaVO datosVentaVo1 = new DatosVentaVO();
      foreach (XElement xelement2 in Enumerable.Select<XElement, XElement>(xelement1.Elements(), (Func<XElement, XElement>) (el => el)))
      {
        recepcionEnvioDte = (csRecepcionEnvioDTE) null;
        if (System.Xml.XPath.Extensions.XPathSelectElement((XNode) xelement2, "Documento/Encabezado/IdDoc/Folio") != null)
        {
          string str = System.Xml.XPath.Extensions.XPathSelectElement((XNode) xelement2, "Documento/Encabezado/IdDoc/Folio").Value;
          if (str.Equals(folio))
          {
            this.txtFolio.Text = str;
            if (System.Xml.XPath.Extensions.XPathSelectElement((XNode) xelement2, "Documento/Encabezado/IdDoc/TipoDTE") != null)
            {
              XElement xelement3 = System.Xml.XPath.Extensions.XPathSelectElement((XNode) xelement2, "Documento/Encabezado/IdDoc/TipoDTE");
              if (xelement3.Value.Equals("33"))
                this.txtTipoDocumento.Text = "FACTURA ELECTRONICA";
              if (xelement3.Value.Equals("56"))
                this.txtTipoDocumento.Text = "NOTA DE DEBITO ELECTRONICA";
              if (xelement3.Value.Equals("61"))
                this.txtTipoDocumento.Text = "NOTA DE CREDITO ELECTRONICA";
            }
            if (System.Xml.XPath.Extensions.XPathSelectElement((XNode) xelement2, "Documento/Encabezado/IdDoc/FchEmis") != null)
              this.txtEmision.Text = System.Xml.XPath.Extensions.XPathSelectElement((XNode) xelement2, "Documento/Encabezado/IdDoc/FchEmis").Value;
            if (System.Xml.XPath.Extensions.XPathSelectElement((XNode) xelement2, "Documento/Encabezado/Emisor/RUTEmisor") != null)
              this.txtRut.Text = System.Xml.XPath.Extensions.XPathSelectElement((XNode) xelement2, "Documento/Encabezado/Emisor/RUTEmisor").Value;
            if (System.Xml.XPath.Extensions.XPathSelectElement((XNode) xelement2, "Documento/Encabezado/Emisor/RznSoc") != null)
              this.txtProveedor.Text = System.Xml.XPath.Extensions.XPathSelectElement((XNode) xelement2, "Documento/Encabezado/Emisor/RznSoc").Value;
            if (System.Xml.XPath.Extensions.XPathSelectElement((XNode) xelement2, "Documento/Encabezado/Receptor/RUTRecep") != null)
              this.txtRutCliente.Text = System.Xml.XPath.Extensions.XPathSelectElement((XNode) xelement2, "Documento/Encabezado/Receptor/RUTRecep").Value;
            if (System.Xml.XPath.Extensions.XPathSelectElement((XNode) xelement2, "Documento/Encabezado/Receptor/RznSocRecep") != null)
              this.txtCliente.Text = System.Xml.XPath.Extensions.XPathSelectElement((XNode) xelement2, "Documento/Encabezado/Receptor/RznSocRecep").Value;
            if (System.Xml.XPath.Extensions.XPathSelectElement((XNode) xelement2, "Documento/DscRcgGlobal/ValorDR") != null)
            {
              XElement xelement3 = System.Xml.XPath.Extensions.XPathSelectElement((XNode) xelement2, "Documento/DscRcgGlobal/ValorDR");
              xelement3.Value = xelement3.Value.Replace(".", ",");
              this.txtDescuento.Text = Convert.ToDecimal(xelement3.Value).ToString("N0");
            }
            if (System.Xml.XPath.Extensions.XPathSelectElement((XNode) xelement2, "Documento/Encabezado/Totales/MntNeto") != null)
            {
              XElement xelement3 = System.Xml.XPath.Extensions.XPathSelectElement((XNode) xelement2, "Documento/Encabezado/Totales/MntNeto");
              xelement3.Value = xelement3.Value.Replace(".", ",");
              this.txtNeto.Text = Convert.ToDecimal(xelement3.Value).ToString("N0");
            }
            if (System.Xml.XPath.Extensions.XPathSelectElement((XNode) xelement2, "Documento/Encabezado/Totales/IVA") != null)
            {
              XElement xelement3 = System.Xml.XPath.Extensions.XPathSelectElement((XNode) xelement2, "Documento/Encabezado/Totales/IVA");
              xelement3.Value = xelement3.Value.Replace(".", ",");
              this.txtIva.Text = Convert.ToDecimal(xelement3.Value).ToString("N0");
            }
            if (System.Xml.XPath.Extensions.XPathSelectElement((XNode) xelement2, "Documento/Encabezado/Totales/MntExe") != null)
            {
              XElement xelement3 = System.Xml.XPath.Extensions.XPathSelectElement((XNode) xelement2, "Documento/Encabezado/Totales/MntExe");
              xelement3.Value = xelement3.Value.Replace(".", ",");
              this.txtExento.Text = Convert.ToDecimal(xelement3.Value).ToString("N0");
            }
            if (System.Xml.XPath.Extensions.XPathSelectElement((XNode) xelement2, "Documento/Encabezado/Totales/MntTotal") != null)
            {
              XElement xelement3 = System.Xml.XPath.Extensions.XPathSelectElement((XNode) xelement2, "Documento/Encabezado/Totales/MntTotal");
              xelement3.Value = xelement3.Value.Replace(".", ",");
              this.txtTotal.Text = Convert.ToDecimal(xelement3.Value).ToString("N0");
            }
            foreach (XElement xelement3 in xelement2.Descendants((XName) "Detalle"))
            {
              DatosVentaVO datosVentaVo2 = new DatosVentaVO();
              if (System.Xml.XPath.Extensions.XPathSelectElement((XNode) xelement3, "NmbItem") != null)
              {
                XElement xelement4 = System.Xml.XPath.Extensions.XPathSelectElement((XNode) xelement3, "NmbItem");
                datosVentaVo2.Descripcion = xelement4.Value;
              }
              if (System.Xml.XPath.Extensions.XPathSelectElement((XNode) xelement3, "QtyItem") != null)
              {
                XElement xelement4 = System.Xml.XPath.Extensions.XPathSelectElement((XNode) xelement3, "QtyItem");
                xelement4.Value = xelement4.Value.Replace(".", ",");
                datosVentaVo2.Cantidad = Convert.ToDecimal(xelement4.Value);
              }
              if (System.Xml.XPath.Extensions.XPathSelectElement((XNode) xelement3, "PrcItem") != null)
              {
                XElement xelement4 = System.Xml.XPath.Extensions.XPathSelectElement((XNode) xelement3, "PrcItem");
                xelement4.Value = xelement4.Value.Replace(".", ",");
                datosVentaVo2.ValorVenta = Convert.ToDecimal(xelement4.Value);
              }
              if (System.Xml.XPath.Extensions.XPathSelectElement((XNode) xelement3, "MontoItem") != null)
              {
                XElement xelement4 = System.Xml.XPath.Extensions.XPathSelectElement((XNode) xelement3, "MontoItem");
                xelement4.Value = xelement4.Value.Replace(".", ",");
                datosVentaVo2.TotalLinea = Convert.ToDecimal(xelement4.Value);
              }
              list.Add(datosVentaVo2);
            }
            if (list.Count > 0)
              this.dgvDatos.DataSource = (object) list;
          }
        }
      }
    }

    private static XElement RemoveAllNamespaces(XElement xmlDocument)
    {
      if (xmlDocument.HasElements)
        return new XElement((XName) xmlDocument.Name.LocalName, (object) Enumerable.Select<XElement, XElement>(xmlDocument.Elements(), (Func<XElement, XElement>) (el => frmIntercambioDetalle.RemoveAllNamespaces(el))));
      XElement xelement = new XElement((XName) xmlDocument.Name.LocalName);
      xelement.Value = xmlDocument.Value;
      foreach (XAttribute xattribute in xmlDocument.Attributes())
        xelement.Add((object) xattribute);
      return xelement;
    }

    public static string RemoveAllNamespaces(string xmlDocument)
    {
      return frmIntercambioDetalle.RemoveAllNamespaces(XElement.Parse(xmlDocument)).ToString();
    }

    private void btnGuardarEstado_Click(object sender, EventArgs e)
    {
      if (this.frmIntercambio == null)
        return;
      this.frmIntercambio.cambiaEstadoDteGrilla(this.cmbAprobacion.SelectedIndex.ToString(), this.cmbAprobacion.Text, this.txtFolio.Text);
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
      DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle3 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle4 = new DataGridViewCellStyle();
      this.panel1 = new Panel();
      this.label4 = new Label();
      this.txtProveedor = new TextBox();
      this.txtRut = new TextBox();
      this.txtEmision = new TextBox();
      this.label3 = new Label();
      this.label1 = new Label();
      this.dgvDatos = new DataGridView();
      this.Codigo = new DataGridViewTextBoxColumn();
      this.Descripcion = new DataGridViewTextBoxColumn();
      this.Precio = new DataGridViewTextBoxColumn();
      this.Cantidad = new DataGridViewTextBoxColumn();
      this.Total = new DataGridViewTextBoxColumn();
      this.label5 = new Label();
      this.label6 = new Label();
      this.label7 = new Label();
      this.label8 = new Label();
      this.txtFolio = new TextBox();
      this.txtTipoDocumento = new TextBox();
      this.txtExento = new TextBox();
      this.txtNeto = new TextBox();
      this.txtIva = new TextBox();
      this.txtTotal = new TextBox();
      this.panel2 = new Panel();
      this.label13 = new Label();
      this.txtDescuento = new TextBox();
      this.panel3 = new Panel();
      this.label11 = new Label();
      this.txtCliente = new TextBox();
      this.txtRutCliente = new TextBox();
      this.label12 = new Label();
      this.tabControl1 = new TabControl();
      this.tabPage1 = new TabPage();
      this.tabPage2 = new TabPage();
      this.label2 = new Label();
      this.panel4 = new Panel();
      this.label9 = new Label();
      this.cmbAprobacion = new ComboBox();
      this.lblAlerta = new Label();
      this.btnGuardarEstado = new Button();
      this.panel1.SuspendLayout();
      ((ISupportInitialize) this.dgvDatos).BeginInit();
      this.panel2.SuspendLayout();
      this.panel3.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.panel4.SuspendLayout();
      this.SuspendLayout();
      this.panel1.BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
      this.panel1.Controls.Add((Control) this.label4);
      this.panel1.Controls.Add((Control) this.txtProveedor);
      this.panel1.Controls.Add((Control) this.txtRut);
      this.panel1.Controls.Add((Control) this.txtEmision);
      this.panel1.Controls.Add((Control) this.label3);
      this.panel1.Controls.Add((Control) this.label1);
      this.panel1.Location = new Point(4, 6);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(493, 111);
      this.panel1.TabIndex = 0;
      this.label4.AutoSize = true;
      this.label4.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label4.Location = new Point(34, 60);
      this.label4.Name = "label4";
      this.label4.Size = new Size(63, 15);
      this.label4.TabIndex = 13;
      this.label4.Text = "Proveedor";
      this.txtProveedor.BackColor = Color.White;
      this.txtProveedor.Enabled = false;
      this.txtProveedor.Location = new Point(101, 57);
      this.txtProveedor.Name = "txtProveedor";
      this.txtProveedor.Size = new Size(379, 20);
      this.txtProveedor.TabIndex = 12;
      this.txtRut.BackColor = Color.White;
      this.txtRut.Enabled = false;
      this.txtRut.Location = new Point(101, 33);
      this.txtRut.Name = "txtRut";
      this.txtRut.Size = new Size(100, 20);
      this.txtRut.TabIndex = 10;
      this.txtEmision.BackColor = Color.White;
      this.txtEmision.Enabled = false;
      this.txtEmision.Location = new Point(101, 9);
      this.txtEmision.Name = "txtEmision";
      this.txtEmision.Size = new Size(100, 20);
      this.txtEmision.TabIndex = 8;
      this.label3.AutoSize = true;
      this.label3.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label3.Location = new Point(71, 36);
      this.label3.Name = "label3";
      this.label3.Size = new Size(26, 15);
      this.label3.TabIndex = 2;
      this.label3.Text = "Rut";
      this.label1.AutoSize = true;
      this.label1.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label1.Location = new Point(8, 12);
      this.label1.Name = "label1";
      this.label1.Size = new Size(89, 15);
      this.label1.TabIndex = 0;
      this.label1.Text = "Fecha Emision";
      gridViewCellStyle1.BackColor = Color.Lavender;
      this.dgvDatos.AlternatingRowsDefaultCellStyle = gridViewCellStyle1;
      this.dgvDatos.BackgroundColor = Color.LightSteelBlue;
      this.dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvDatos.Columns.AddRange((DataGridViewColumn) this.Codigo, (DataGridViewColumn) this.Descripcion, (DataGridViewColumn) this.Precio, (DataGridViewColumn) this.Cantidad, (DataGridViewColumn) this.Total);
      this.dgvDatos.GridColor = Color.Black;
      this.dgvDatos.Location = new Point(4, 155);
      this.dgvDatos.Name = "dgvDatos";
      this.dgvDatos.RowHeadersVisible = false;
      this.dgvDatos.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dgvDatos.ScrollBars = ScrollBars.Vertical;
      this.dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvDatos.Size = new Size(700, 235);
      this.dgvDatos.TabIndex = 1;
      this.Codigo.HeaderText = "Codigo";
      this.Codigo.Name = "Codigo";
      this.Descripcion.DataPropertyName = "Descripcion";
      this.Descripcion.HeaderText = "Descripcion";
      this.Descripcion.Name = "Descripcion";
      this.Descripcion.Width = 280;
      this.Precio.DataPropertyName = "ValorVenta";
      gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
      gridViewCellStyle2.Format = "N0";
      gridViewCellStyle2.NullValue = (object) "0";
      this.Precio.DefaultCellStyle = gridViewCellStyle2;
      this.Precio.HeaderText = "Precio";
      this.Precio.Name = "Precio";
      this.Cantidad.DataPropertyName = "Cantidad";
      gridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
      gridViewCellStyle3.Format = "N0";
      gridViewCellStyle3.NullValue = (object) "0";
      this.Cantidad.DefaultCellStyle = gridViewCellStyle3;
      this.Cantidad.HeaderText = "Cantidad";
      this.Cantidad.Name = "Cantidad";
      this.Total.DataPropertyName = "TotalLinea";
      gridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
      gridViewCellStyle4.Format = "N0";
      gridViewCellStyle4.NullValue = (object) "0";
      this.Total.DefaultCellStyle = gridViewCellStyle4;
      this.Total.HeaderText = "Total";
      this.Total.Name = "Total";
      this.label5.AutoSize = true;
      this.label5.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label5.Location = new Point(9, 38);
      this.label5.Name = "label5";
      this.label5.Size = new Size(51, 15);
      this.label5.TabIndex = 4;
      this.label5.Text = "Exento";
      this.label6.AutoSize = true;
      this.label6.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label6.Location = new Point(9, 64);
      this.label6.Name = "label6";
      this.label6.Size = new Size(37, 15);
      this.label6.TabIndex = 5;
      this.label6.Text = "Neto";
      this.label7.AutoSize = true;
      this.label7.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label7.Location = new Point(9, 90);
      this.label7.Name = "label7";
      this.label7.Size = new Size(25, 15);
      this.label7.TabIndex = 6;
      this.label7.Text = "Iva";
      this.label8.AutoSize = true;
      this.label8.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label8.Location = new Point(9, 116);
      this.label8.Name = "label8";
      this.label8.Size = new Size(39, 15);
      this.label8.TabIndex = 7;
      this.label8.Text = "Total";
      this.txtFolio.BackColor = Color.White;
      this.txtFolio.BorderStyle = BorderStyle.None;
      this.txtFolio.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtFolio.ForeColor = Color.Red;
      this.txtFolio.Location = new Point(36, 51);
      this.txtFolio.Name = "txtFolio";
      this.txtFolio.ReadOnly = true;
      this.txtFolio.Size = new Size(100, 14);
      this.txtFolio.TabIndex = 9;
      this.txtFolio.Text = "1234";
      this.txtTipoDocumento.BackColor = Color.White;
      this.txtTipoDocumento.BorderStyle = BorderStyle.None;
      this.txtTipoDocumento.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtTipoDocumento.ForeColor = Color.Red;
      this.txtTipoDocumento.Location = new Point(8, 17);
      this.txtTipoDocumento.Multiline = true;
      this.txtTipoDocumento.Name = "txtTipoDocumento";
      this.txtTipoDocumento.ReadOnly = true;
      this.txtTipoDocumento.Size = new Size(172, 30);
      this.txtTipoDocumento.TabIndex = 11;
      this.txtTipoDocumento.Text = "Factura Electronica";
      this.txtExento.BackColor = Color.White;
      this.txtExento.Enabled = false;
      this.txtExento.Location = new Point(89, 35);
      this.txtExento.Name = "txtExento";
      this.txtExento.Size = new Size(134, 20);
      this.txtExento.TabIndex = 13;
      this.txtExento.TextAlign = HorizontalAlignment.Right;
      this.txtNeto.BackColor = Color.White;
      this.txtNeto.Enabled = false;
      this.txtNeto.Location = new Point(89, 61);
      this.txtNeto.Name = "txtNeto";
      this.txtNeto.Size = new Size(134, 20);
      this.txtNeto.TabIndex = 14;
      this.txtNeto.TextAlign = HorizontalAlignment.Right;
      this.txtIva.BackColor = Color.White;
      this.txtIva.Enabled = false;
      this.txtIva.Location = new Point(89, 87);
      this.txtIva.Name = "txtIva";
      this.txtIva.Size = new Size(134, 20);
      this.txtIva.TabIndex = 15;
      this.txtIva.TextAlign = HorizontalAlignment.Right;
      this.txtTotal.BackColor = Color.White;
      this.txtTotal.Enabled = false;
      this.txtTotal.Location = new Point(89, 113);
      this.txtTotal.Name = "txtTotal";
      this.txtTotal.Size = new Size(134, 20);
      this.txtTotal.TabIndex = 16;
      this.txtTotal.TextAlign = HorizontalAlignment.Right;
      this.panel2.BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
      this.panel2.BorderStyle = BorderStyle.FixedSingle;
      this.panel2.Controls.Add((Control) this.label13);
      this.panel2.Controls.Add((Control) this.txtDescuento);
      this.panel2.Controls.Add((Control) this.txtExento);
      this.panel2.Controls.Add((Control) this.txtTotal);
      this.panel2.Controls.Add((Control) this.txtNeto);
      this.panel2.Controls.Add((Control) this.txtIva);
      this.panel2.Controls.Add((Control) this.label5);
      this.panel2.Controls.Add((Control) this.label6);
      this.panel2.Controls.Add((Control) this.label8);
      this.panel2.Controls.Add((Control) this.label7);
      this.panel2.Location = new Point(474, 395);
      this.panel2.Name = "panel2";
      this.panel2.Size = new Size(230, 148);
      this.panel2.TabIndex = 17;
      this.label13.AutoSize = true;
      this.label13.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label13.Location = new Point(9, 10);
      this.label13.Name = "label13";
      this.label13.Size = new Size(75, 15);
      this.label13.TabIndex = 18;
      this.label13.Text = "Descuento";
      this.txtDescuento.BackColor = Color.White;
      this.txtDescuento.Enabled = false;
      this.txtDescuento.Location = new Point(89, 9);
      this.txtDescuento.Name = "txtDescuento";
      this.txtDescuento.Size = new Size(134, 20);
      this.txtDescuento.TabIndex = 17;
      this.txtDescuento.TextAlign = HorizontalAlignment.Right;
      this.panel3.BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
      this.panel3.Controls.Add((Control) this.label11);
      this.panel3.Controls.Add((Control) this.txtCliente);
      this.panel3.Controls.Add((Control) this.txtRutCliente);
      this.panel3.Controls.Add((Control) this.label12);
      this.panel3.Location = new Point(6, 6);
      this.panel3.Name = "panel3";
      this.panel3.Size = new Size(489, 111);
      this.panel3.TabIndex = 18;
      this.label11.AutoSize = true;
      this.label11.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label11.Location = new Point(5, 36);
      this.label11.Name = "label11";
      this.label11.Size = new Size(45, 15);
      this.label11.TabIndex = 23;
      this.label11.Text = "Cliente";
      this.txtCliente.BackColor = Color.White;
      this.txtCliente.Enabled = false;
      this.txtCliente.Location = new Point(54, 33);
      this.txtCliente.Name = "txtCliente";
      this.txtCliente.Size = new Size(379, 20);
      this.txtCliente.TabIndex = 22;
      this.txtRutCliente.BackColor = Color.White;
      this.txtRutCliente.Enabled = false;
      this.txtRutCliente.Location = new Point(54, 8);
      this.txtRutCliente.Name = "txtRutCliente";
      this.txtRutCliente.Size = new Size(100, 20);
      this.txtRutCliente.TabIndex = 21;
      this.label12.AutoSize = true;
      this.label12.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label12.Location = new Point(24, 11);
      this.label12.Name = "label12";
      this.label12.Size = new Size(26, 15);
      this.label12.TabIndex = 20;
      this.label12.Text = "Rut";
      this.tabControl1.Controls.Add((Control) this.tabPage1);
      this.tabControl1.Controls.Add((Control) this.tabPage2);
      this.tabControl1.Location = new Point(4, 6);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new Size(509, 148);
      this.tabControl1.TabIndex = 19;
      this.tabPage1.BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
      this.tabPage1.Controls.Add((Control) this.panel1);
      this.tabPage1.Location = new Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new Padding(3);
      this.tabPage1.Size = new Size(501, 122);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Datos del proveedor Emisor del DTE";
      this.tabPage2.BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
      this.tabPage2.Controls.Add((Control) this.panel3);
      this.tabPage2.Location = new Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new Padding(3);
      this.tabPage2.Size = new Size(501, 122);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Datos del Cliente Receptor del DTE";
      this.label2.AutoSize = true;
      this.label2.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label2.ForeColor = Color.Red;
      this.label2.Location = new Point(8, 51);
      this.label2.Name = "label2";
      this.label2.Size = new Size(23, 15);
      this.label2.TabIndex = 1;
      this.label2.Text = "N°";
      this.panel4.BackColor = Color.White;
      this.panel4.BorderStyle = BorderStyle.FixedSingle;
      this.panel4.Controls.Add((Control) this.txtTipoDocumento);
      this.panel4.Controls.Add((Control) this.txtFolio);
      this.panel4.Controls.Add((Control) this.label2);
      this.panel4.Location = new Point(515, 26);
      this.panel4.Name = "panel4";
      this.panel4.Size = new Size(186, 83);
      this.panel4.TabIndex = 20;
      this.label9.BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
      this.label9.BorderStyle = BorderStyle.FixedSingle;
      this.label9.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label9.Location = new Point(4, 398);
      this.label9.Name = "label9";
      this.label9.Size = new Size(258, 23);
      this.label9.TabIndex = 21;
      this.label9.Text = "Aprobacion";
      this.cmbAprobacion.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbAprobacion.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmbAprobacion.ForeColor = Color.Black;
      this.cmbAprobacion.FormattingEnabled = true;
      this.cmbAprobacion.Items.AddRange(new object[3]
      {
        (object) "DTE Aceptado OK",
        (object) "DTE Aceptado con Discrepancia",
        (object) "DTE Rechazado"
      });
      this.cmbAprobacion.Location = new Point(4, 419);
      this.cmbAprobacion.Name = "cmbAprobacion";
      this.cmbAprobacion.Size = new Size(258, 24);
      this.cmbAprobacion.TabIndex = 22;
      this.lblAlerta.AutoSize = true;
      this.lblAlerta.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblAlerta.Location = new Point(5, 457);
      this.lblAlerta.Name = "lblAlerta";
      this.lblAlerta.Size = new Size(11, 15);
      this.lblAlerta.TabIndex = 23;
      this.lblAlerta.Text = ".";
      this.btnGuardarEstado.Location = new Point(268, 420);
      this.btnGuardarEstado.Name = "btnGuardarEstado";
      this.btnGuardarEstado.Size = new Size(75, 23);
      this.btnGuardarEstado.TabIndex = 24;
      this.btnGuardarEstado.Text = "Guardar";
      this.btnGuardarEstado.UseVisualStyleBackColor = true;
      this.btnGuardarEstado.Click += new EventHandler(this.btnGuardarEstado_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
//      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(223, 233, 245);
      this.ClientSize = new Size(708, 547);
      this.Controls.Add((Control) this.btnGuardarEstado);
      this.Controls.Add((Control) this.lblAlerta);
      this.Controls.Add((Control) this.cmbAprobacion);
      this.Controls.Add((Control) this.label9);
      this.Controls.Add((Control) this.panel4);
      this.Controls.Add((Control) this.tabControl1);
      this.Controls.Add((Control) this.panel2);
      this.Controls.Add((Control) this.dgvDatos);
//      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Name = "frmIntercambioDetalle";
      this.Text = "Detalle Dte";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((ISupportInitialize) this.dgvDatos).EndInit();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.panel3.ResumeLayout(false);
      this.panel3.PerformLayout();
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage2.ResumeLayout(false);
      this.panel4.ResumeLayout(false);
      this.panel4.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
