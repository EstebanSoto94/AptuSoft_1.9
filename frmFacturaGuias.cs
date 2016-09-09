 
// Type: Aptusoft.frmFacturaGuias
 
 
// version 1.8.0

using Aptusoft.FacturaElectronica.Clases;
using Aptusoft.FacturaElectronica.Formularios;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Aptusoft
{
  public class frmFacturaGuias : Form
  {
    private IContainer components = (IContainer) null;
    private frmFactura frmFac = (frmFactura) null;
    private frmFacturaExenta frmFacExe = (frmFacturaExenta) null;
    private frmFacturaElectronica frmFacEle = (frmFacturaElectronica) null;
    private frmFacturaElectronicaFrigo frmFacElecFrigo = (frmFacturaElectronicaFrigo)null;
    private frmFacturaExentaElectronica frmFacExeEle = (frmFacturaExentaElectronica) null;
    private string textoAlerta = "";
    private GroupBox groupBox1;
    private Button btnBuscarCliente;
    private TextBox txtRazonSocial;
    private TextBox txtDigito;
    private TextBox txtRut;
    private Label label2;
    private Label label1;
    private Button btnMostrarGuias;
    private DataGridView dgvGuias;
    private Button btnFacturarGuias;
    private Button btnSeleccionaTodo;
    private Button btnSalir;
    private Button btnNoSeleccionar;
    private Button btnLimpiar;
    private CheckBox chkSeleccionarTodas;
    private frmFacturaGuias intance;
    private int codigoCliente;
    private string modulo;
    private string moduloAfacturar;

    public frmFacturaGuias(ref frmFactura f, string modulo, string moduloAfacturar)
    {
      this.InitializeComponent();
      this.intance = this;
      this.frmFac = f;
      this.modulo = modulo;
      this.moduloAfacturar = moduloAfacturar;
      this.iniciaFormulario();
    }

    public frmFacturaGuias(ref frmFacturaExenta fe, string modulo)
    {
      this.InitializeComponent();
      this.intance = this;
      this.frmFacExe = fe;
      this.modulo = modulo;
      this.iniciaFormulario();
    }

    public frmFacturaGuias(ref frmFacturaElectronica fe, string modulo, string moduloAfacturar)
    {
      this.InitializeComponent();
      this.intance = this;
      this.frmFacEle = fe;
      this.modulo = modulo;
      this.moduloAfacturar = moduloAfacturar;
      this.iniciaFormulario();
    }

    public frmFacturaGuias(ref frmFacturaElectronicaFrigo fe, string modulo, string moduloAfacturar)
    {
        this.InitializeComponent();
        this.intance = this;
        this.frmFacElecFrigo = fe;
        this.modulo = modulo;
        this.moduloAfacturar = moduloAfacturar;
        this.iniciaFormulario();
    }

    public frmFacturaGuias(ref frmFacturaExentaElectronica fee, string modulo, string moduloAfacturar)
    {
      this.InitializeComponent();
      this.intance = this;
      this.frmFacExeEle = fee;
      this.modulo = modulo;
      this.moduloAfacturar = moduloAfacturar;
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtDigito = new System.Windows.Forms.TextBox();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMostrarGuias = new System.Windows.Forms.Button();
            this.dgvGuias = new System.Windows.Forms.DataGridView();
            this.btnFacturarGuias = new System.Windows.Forms.Button();
            this.btnSeleccionaTodo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnNoSeleccionar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.chkSeleccionarTodas = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuias)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRazonSocial);
            this.groupBox1.Controls.Add(this.btnBuscarCliente);
            this.groupBox1.Controls.Add(this.txtDigito);
            this.groupBox1.Controls.Add(this.txtRut);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(595, 62);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(151, 32);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(314, 20);
            this.txtRazonSocial.TabIndex = 4;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarCliente.Location = new System.Drawing.Point(471, 27);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(94, 25);
            this.btnBuscarCliente.TabIndex = 5;
            this.btnBuscarCliente.Text = "Buscar Cliente";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txtDigito
            // 
            this.txtDigito.Location = new System.Drawing.Point(111, 32);
            this.txtDigito.Name = "txtDigito";
            this.txtDigito.Size = new System.Drawing.Size(35, 20);
            this.txtDigito.TabIndex = 3;
            this.txtDigito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDigito_KeyPress);
            // 
            // txtRut
            // 
            this.txtRut.Location = new System.Drawing.Point(8, 32);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(100, 20);
            this.txtRut.TabIndex = 2;
            this.txtRut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRut_KeyPress);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(151, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "RAZON SOCIAL";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "RUT";
            // 
            // btnMostrarGuias
            // 
            this.btnMostrarGuias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarGuias.Location = new System.Drawing.Point(518, 72);
            this.btnMostrarGuias.Name = "btnMostrarGuias";
            this.btnMostrarGuias.Size = new System.Drawing.Size(81, 58);
            this.btnMostrarGuias.TabIndex = 1;
            this.btnMostrarGuias.Text = "BUSCAR GUIAS";
            this.btnMostrarGuias.UseVisualStyleBackColor = true;
            this.btnMostrarGuias.Click += new System.EventHandler(this.btnMostrarGuias_Click);
            // 
            // dgvGuias
            // 
            this.dgvGuias.AllowUserToAddRows = false;
            this.dgvGuias.AllowUserToDeleteRows = false;
            this.dgvGuias.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvGuias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGuias.Location = new System.Drawing.Point(4, 97);
            this.dgvGuias.Name = "dgvGuias";
            this.dgvGuias.RowHeadersVisible = false;
            this.dgvGuias.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvGuias.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGuias.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvGuias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGuias.Size = new System.Drawing.Size(508, 379);
            this.dgvGuias.TabIndex = 2;
            // 
            // btnFacturarGuias
            // 
            this.btnFacturarGuias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturarGuias.Location = new System.Drawing.Point(518, 252);
            this.btnFacturarGuias.Name = "btnFacturarGuias";
            this.btnFacturarGuias.Size = new System.Drawing.Size(81, 58);
            this.btnFacturarGuias.TabIndex = 3;
            this.btnFacturarGuias.Text = "FACTURAR GUIAS";
            this.btnFacturarGuias.UseVisualStyleBackColor = true;
            this.btnFacturarGuias.Click += new System.EventHandler(this.btnFacturarGuias_Click);
            // 
            // btnSeleccionaTodo
            // 
            this.btnSeleccionaTodo.Location = new System.Drawing.Point(518, 132);
            this.btnSeleccionaTodo.Name = "btnSeleccionaTodo";
            this.btnSeleccionaTodo.Size = new System.Drawing.Size(81, 58);
            this.btnSeleccionaTodo.TabIndex = 4;
            this.btnSeleccionaTodo.Text = "Seleccionar Todo";
            this.btnSeleccionaTodo.UseVisualStyleBackColor = true;
            this.btnSeleccionaTodo.Visible = false;
            this.btnSeleccionaTodo.Click += new System.EventHandler(this.btnSeleccionaTodo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(518, 419);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(81, 58);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnNoSeleccionar
            // 
            this.btnNoSeleccionar.Location = new System.Drawing.Point(518, 192);
            this.btnNoSeleccionar.Name = "btnNoSeleccionar";
            this.btnNoSeleccionar.Size = new System.Drawing.Size(81, 58);
            this.btnNoSeleccionar.TabIndex = 6;
            this.btnNoSeleccionar.Text = "Desmarcar Todo";
            this.btnNoSeleccionar.UseVisualStyleBackColor = true;
            this.btnNoSeleccionar.Visible = false;
            this.btnNoSeleccionar.Click += new System.EventHandler(this.brnNoSeleccionar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(518, 355);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(81, 58);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // chkSeleccionarTodas
            // 
            this.chkSeleccionarTodas.AutoSize = true;
            this.chkSeleccionarTodas.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkSeleccionarTodas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSeleccionarTodas.Location = new System.Drawing.Point(316, 72);
            this.chkSeleccionarTodas.Name = "chkSeleccionarTodas";
            this.chkSeleccionarTodas.Size = new System.Drawing.Size(145, 19);
            this.chkSeleccionarTodas.TabIndex = 8;
            this.chkSeleccionarTodas.Text = "Seleccionar Todas";
            this.chkSeleccionarTodas.UseVisualStyleBackColor = true;
            this.chkSeleccionarTodas.CheckedChanged += new System.EventHandler(this.chkSeleccionarTodas_CheckedChanged);
            // 
            // frmFacturaGuias
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(602, 490);
            this.Controls.Add(this.chkSeleccionarTodas);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnNoSeleccionar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnSeleccionaTodo);
            this.Controls.Add(this.btnFacturarGuias);
            this.Controls.Add(this.dgvGuias);
            this.Controls.Add(this.btnMostrarGuias);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmFacturaGuias";
            this.ShowIcon = false;
            this.Text = "Facturar Guias de Despacho";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private void iniciaFormulario()
    {
      this.dgvGuias.DataSource = (object) null;
      this.dgvGuias.Columns.Clear();
      this.creaColumnasDetalle();
      this.btnFacturarGuias.Enabled = false;
      this.btnSeleccionaTodo.Enabled = false;
      this.btnNoSeleccionar.Enabled = false;
      this.btnMostrarGuias.Enabled = false;
      this.txtRut.Clear();
      this.txtDigito.Clear();
      this.txtRazonSocial.Clear();
      this.txtRut.Focus();
      if (!this.modulo.Equals("factura") && !this.modulo.Equals("factura_electronica") && !this.modulo.Equals("factura_exenta_electronica"))
        return;
      if (this.moduloAfacturar.Equals("guias"))
      {
        this.Text = "Facturar Guias de Despacho";
        this.btnMostrarGuias.Text = "BUSCAR GUIAS";
        this.btnFacturarGuias.Text = "FACTURAR GUIAS";
        this.textoAlerta = "Guias";
      }
      else
      {
        this.Text = "Facturar Notas de Venta";
        this.btnMostrarGuias.Text = "Buscar Nota Venta";
        this.btnFacturarGuias.Text = "Facturar Notas Ventas";
        this.textoAlerta = "Notas de Venta";
      }
    }

    private void creaColumnasDetalle()
    {
      this.dgvGuias.AutoGenerateColumns = false;
      this.dgvGuias.Columns.Add("IdGuia", "Id");
      this.dgvGuias.Columns[0].DataPropertyName = "IdFactura";
      this.dgvGuias.Columns[0].Width = 60;
      this.dgvGuias.Columns[0].Resizable = DataGridViewTriState.False;
      this.dgvGuias.Columns[0].ReadOnly = true;
      this.dgvGuias.Columns[0].Visible = false;
      this.dgvGuias.Columns.Add("Documento", "Documento");
      this.dgvGuias.Columns[1].DataPropertyName = "DocumentoVenta";
      this.dgvGuias.Columns[1].Width = 140;
      this.dgvGuias.Columns[1].Resizable = DataGridViewTriState.False;
      this.dgvGuias.Columns[1].ReadOnly = true;
      this.dgvGuias.Columns.Add("Folio", "Folio");
      this.dgvGuias.Columns[2].DataPropertyName = "Folio";
      this.dgvGuias.Columns[2].Width = 95;
      this.dgvGuias.Columns[2].Resizable = DataGridViewTriState.False;
      this.dgvGuias.Columns[2].ReadOnly = true;
      this.dgvGuias.Columns.Add("FechaEmision", "Fecha");
      this.dgvGuias.Columns[3].DataPropertyName = "FechaEmision";
      this.dgvGuias.Columns[3].Width = 100;
      this.dgvGuias.Columns[3].Resizable = DataGridViewTriState.False;
      this.dgvGuias.Columns[3].ReadOnly = true;
      this.dgvGuias.Columns.Add("Total", "Total");
      this.dgvGuias.Columns[4].DataPropertyName = "Total";
      this.dgvGuias.Columns[4].Width = 80;
      this.dgvGuias.Columns[4].DefaultCellStyle.Format = "C0";
      this.dgvGuias.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvGuias.Columns[4].Resizable = DataGridViewTriState.False;
      this.dgvGuias.Columns[4].ReadOnly = true;
      this.dgvGuias.Columns.Add("SubTotal", "SubTotal");
      this.dgvGuias.Columns[5].DataPropertyName = "SubTotal";
      this.dgvGuias.Columns[5].Width = 80;
      this.dgvGuias.Columns[5].DefaultCellStyle.Format = "C0";
      this.dgvGuias.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvGuias.Columns[5].Resizable = DataGridViewTriState.False;
      this.dgvGuias.Columns[5].ReadOnly = true;
      DataGridViewCheckBoxColumn viewCheckBoxColumn = new DataGridViewCheckBoxColumn();
      viewCheckBoxColumn.Name = "Selecciona";
      viewCheckBoxColumn.HeaderText = "Seleccione";
      viewCheckBoxColumn.Width = 70;
      viewCheckBoxColumn.DisplayIndex = 5;
      viewCheckBoxColumn.FalseValue = (object) 0;
      viewCheckBoxColumn.TrueValue = (object) 1;
      this.dgvGuias.Columns.Add((DataGridViewColumn) viewCheckBoxColumn);
    }

    private void btnBuscarCliente_Click(object sender, EventArgs e)
    {
      int num = (int) new frmBuscaClientes(ref this.intance, "factura_guias").ShowDialog();
    }

    private void txtRut_KeyPress(object sender, KeyPressEventArgs e)
    {
      if ((int) e.KeyChar != 13)
        return;
      e.Handled = false;
      this.txtDigito.Focus();
    }

    private void txtDigito_KeyPress(object sender, KeyPressEventArgs e)
    {
      if ((int) e.KeyChar != 13)
        return;
      e.Handled = false;
      if (this.txtRut.Text.Length > 0)
      {
        this.buscaCliente();
      }
      else
      {
        int num = (int) MessageBox.Show("Debe Ingresar RUT a Buscar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.txtRut.Focus();
      }
    }

    private void buscaCliente()
    {
      ArrayList arrayList = new ArrayList();
      ArrayList cli = new Cliente().buscaRutCliente(this.txtRut.Text.Trim());
      if (cli.Count > 1)
      {
        this.txtRazonSocial.Enabled = false;
        int num = (int) new frmClienteMismoRut(cli, ref this.intance, "factura_guias").ShowDialog();
      }
      else if (cli.Count == 0)
      {
        int num1 = (int) MessageBox.Show("No Existe Cliente Consultado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      else
      {
        if (cli.Count != 1)
          return;
        foreach (ClienteVO clienteVo in cli)
          this.buscaClienteCodigo(clienteVo.Codigo);
      }
    }

    public void buscaClienteCodigo(int cod)
    {
      ClienteVO clienteVo = new Cliente().buscaCodigoCliente(cod);
      this.codigoCliente = clienteVo.Codigo;
      this.txtRut.Text = clienteVo.Rut;
      this.txtDigito.Text = clienteVo.Digito;
      this.txtRazonSocial.Text = clienteVo.RazonSocial;
      this.btnMostrarGuias.Enabled = true;
      this.btnMostrarGuias.Focus();
    }

    private void btnMostrarGuias_Click(object sender, EventArgs e)
    {
      if (this.modulo.Equals("factura") || this.modulo.Equals("factura_electronica") || this.modulo.Equals("factura_exenta_electronica"))
      {
        if (this.moduloAfacturar.Equals("guias"))
        {
          List<Venta> list = new List<Venta>();
          if (this.modulo.Equals("factura"))
            list = new Guia().buscaGuiasSinFacturar(this.codigoCliente);
          if (this.modulo.Equals("factura_electronica"))
            list = new EGuia().buscaGuiaseElectronicaSinFacturar(this.codigoCliente);
          if (this.modulo.Equals("factura_exenta_electronica"))
            list = new EGuia().buscaGuiaseElectronicaSinFacturar(this.codigoCliente);
          if (list.Count > 0)
          {
            this.dgvGuias.DataSource = (object) list;
            this.btnFacturarGuias.Enabled = true;
            this.btnSeleccionaTodo.Enabled = true;
            this.btnNoSeleccionar.Enabled = true;
            this.btnMostrarGuias.Enabled = false;
          }
          else
          {
            int num = (int) MessageBox.Show("No Se encontraron " + this.textoAlerta + " Sin Facturar para este Cliente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.iniciaFormulario();
          }
        }
        else
        {
          List<Venta> list = new NotaVenta().buscaNotasDeVentaSinFacturar(this.codigoCliente);
          if (list.Count > 0)
          {
            this.dgvGuias.DataSource = (object) list;
            this.btnFacturarGuias.Enabled = true;
            this.btnSeleccionaTodo.Enabled = true;
            this.btnNoSeleccionar.Enabled = true;
            this.btnMostrarGuias.Enabled = false;
          }
          else
          {
            int num = (int) MessageBox.Show("No Se encontraron " + this.textoAlerta + " Sin Facturar para este Cliente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.iniciaFormulario();
          }
        }
      }
      else
      {
        List<Venta> list = new Guia().buscaGuiasSinFacturar(this.codigoCliente);
        if (list.Count > 0)
        {
          this.dgvGuias.DataSource = (object) list;
          this.btnFacturarGuias.Enabled = true;
          this.btnSeleccionaTodo.Enabled = true;
          this.btnNoSeleccionar.Enabled = true;
          this.btnMostrarGuias.Enabled = false;
        }
        else
        {
          int num = (int) MessageBox.Show("No Se encontraron " + this.textoAlerta + " Sin Facturar para este Cliente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          this.iniciaFormulario();
        }
      }
    }

    private void btnSeleccionaTodo_Click(object sender, EventArgs e)
    {
      foreach (DataGridViewRow dataGridViewRow in (IEnumerable) this.dgvGuias.Rows)
        dataGridViewRow.Cells["Selecciona"].Value = (object) true;
    }

    private void btnFacturarGuias_Click(object sender, EventArgs e)
    {
      int num1 = 0;
      List<Venta> list = new List<Venta>();
      foreach (DataGridViewRow dataGridViewRow in (IEnumerable) this.dgvGuias.Rows)
      {
        if (Convert.ToBoolean(dataGridViewRow.Cells["Selecciona"].Value))
        {
          list.Add(new Venta()
          {
            IdCliente = this.codigoCliente,
            IdFactura = Convert.ToInt32(dataGridViewRow.Cells["IdGuia"].Value.ToString()),
            Folio = Convert.ToInt32(dataGridViewRow.Cells["Folio"].Value.ToString()),
            FechaEmision = Convert.ToDateTime(dataGridViewRow.Cells["FechaEmision"].Value.ToString()),
            Total = Convert.ToDecimal(dataGridViewRow.Cells["Total"].Value.ToString()),
            SubTotal = Convert.ToDecimal(dataGridViewRow.Cells["SubTotal"].Value.ToString())
          });
          ++num1;
        }
      }
      if (num1 > 0)
      {
        if (this.modulo.Equals("factura"))
        {
          if (this.moduloAfacturar.Equals("guias"))
            this.frmFac.facturaGuias(list);
          else
            this.frmFac.facturaNotaVentaMasiva(list);
          this.Close();
        }
        if (this.modulo.Equals("factura_electronica"))
        {
          if (this.moduloAfacturar.Equals("guias"))
            this.frmFacEle.facturaGuias(list);
          else
            this.frmFacEle.facturaNotaVentaMasiva(list);
          this.Close();
        }
        if (this.modulo.Equals("factura_exenta_electronica"))
        {
          if (this.moduloAfacturar.Equals("guias"))
            this.frmFacExeEle.facturaGuias(list);
          this.Close();
        }
        if (!this.modulo.Equals("factura_exenta"))
          return;
        this.frmFacExe.facturaGuias(list);
        this.Close();
      }
      else
      {
        int num2 = (int) MessageBox.Show("Debe Seleccionar a lo menos una " + this.textoAlerta, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
      this.Close();
      this.Dispose();
    }

    private void brnNoSeleccionar_Click(object sender, EventArgs e)
    {
      foreach (DataGridViewRow dataGridViewRow in (IEnumerable) this.dgvGuias.Rows)
        dataGridViewRow.Cells["Selecciona"].Value = (object) false;
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
      this.iniciaFormulario();
    }

    private void chkSeleccionarTodas_CheckedChanged(object sender, EventArgs e)
    {
      if (this.dgvGuias.RowCount <= 0)
        return;
      if (this.chkSeleccionarTodas.Checked)
      {
        foreach (DataGridViewRow dataGridViewRow in (IEnumerable) this.dgvGuias.Rows)
          dataGridViewRow.Cells["Selecciona"].Value = (object) true;
      }
      else
      {
        foreach (DataGridViewRow dataGridViewRow in (IEnumerable) this.dgvGuias.Rows)
          dataGridViewRow.Cells["Selecciona"].Value = (object) false;
      }
    }
  }
}
