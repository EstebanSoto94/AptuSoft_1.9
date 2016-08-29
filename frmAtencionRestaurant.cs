 
// Type: Aptusoft.frmAtencionRestaurant
 
 
// version 1.8.0

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Aptusoft
{
  public class frmAtencionRestaurant : Form
  {
    private List<MesaVO> listaMesas = new List<MesaVO>();
    private List<Venta> listaPedidos = new List<Venta>();
    private IContainer components = (IContainer) null;
    private DataGridView dgvMesas;
    private DataGridView dgvPedidos;
    private Button btnAgregarPedido;
    private Button btnSalir;
    private DataGridViewTextBoxColumn Folio;
    private DataGridViewTextBoxColumn Numero;
    private DataGridViewTextBoxColumn Cliente;
    private DataGridViewTextBoxColumn Tipo;
    private DataGridViewButtonColumn AgregarPedido;
    private Button btnActualizar;
    private Timer timer1;
    private TabControl tabControl1;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private DataGridViewTextBoxColumn IdMesa;
    private DataGridViewTextBoxColumn folioComanda;
    private DataGridViewTextBoxColumn NombreMesa;
    private DataGridViewTextBoxColumn Estado;
    private DataGridViewTextBoxColumn Garzon;
    private DataGridViewButtonColumn Seleccionar;
    private DataGridViewButtonColumn Reserva;
    private DataGridViewButtonColumn Liberar;
    private Panel panel3;
    private Panel panel2;
    private Panel panel1;
    private Label label3;
    private Label label2;
    private Label label1;

    public frmAtencionRestaurant()
    {
      this.InitializeComponent();
      this.dgvMesas.AutoGenerateColumns = false;
      this.dgvPedidos.AutoGenerateColumns = false;
      this.cargaMesas();
      this.cargaLLevarDomicilio();
      this.timer1.Start();
      this.btnActualizar.Focus();
    }

    private void frmAtencionRestaurant_Load(object sender, EventArgs e)
    {
      this.colorMesa();
    }

    public void cargaMesas()
    {
      this.dgvMesas.DataSource = (object) null;
      this.listaMesas = new Mesa().listaMesas();
      this.dgvMesas.DataSource = (object) this.listaMesas;
      this.colorMesa();
    }

    private void colorMesa()
    {
      for (int index = 0; index < this.dgvMesas.RowCount; ++index)
      {
        string str = this.dgvMesas.Rows[index].Cells["Estado"].Value.ToString();
        if (str.Equals("DISPONIBLE"))
        {
          this.dgvMesas.Rows[index].DefaultCellStyle.BackColor = Color.GreenYellow;
          this.dgvMesas.Rows[index].DefaultCellStyle.ForeColor = Color.Black;
        }
        if (str.Equals("OCUPADA"))
        {
          this.dgvMesas.Rows[index].DefaultCellStyle.BackColor = Color.Red;
          this.dgvMesas.Rows[index].DefaultCellStyle.ForeColor = Color.White;
        }
        if (str.Equals("RESERVADA"))
        {
          this.dgvMesas.Rows[index].DefaultCellStyle.BackColor = Color.Orange;
          this.dgvMesas.Rows[index].DefaultCellStyle.ForeColor = Color.Black;
        }
      }
    }

    public void cargaLLevarDomicilio()
    {
      this.dgvPedidos.DataSource = (object) null;
      this.listaPedidos = new Comanda().buscaComandaLlevarDomicilio();
      this.dgvPedidos.DataSource = (object) this.listaPedidos;
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
      frmMenuPrincipal._modComanda = 0;
      this.Close();
    }

    private void dgvMesas_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.dgvMesas.Columns[e.ColumnIndex].Name == "Seleccionar")
      {
        int num = (int) new frmComanda("MESA", this.dgvMesas.SelectedRows[0].Cells["NombreMesa"].Value.ToString(), this.dgvMesas.SelectedRows[0].Cells["Estado"].Value.ToString(), this.dgvMesas.SelectedRows[0].Cells["Garzon"].Value != null ? this.dgvMesas.SelectedRows[0].Cells["Garzon"].Value.ToString() : "", Convert.ToInt32(this.dgvMesas.SelectedRows[0].Cells["FolioComanda"].Value.ToString())).ShowDialog();
        this.cargaMesas();
      }
      if (this.dgvMesas.Columns[e.ColumnIndex].Name == "Reserva")
      {
        int num = (int) new frmComanda("RESERVA", this.dgvMesas.SelectedRows[0].Cells["NombreMesa"].Value.ToString(), this.dgvMesas.SelectedRows[0].Cells["Estado"].Value.ToString(), this.dgvMesas.SelectedRows[0].Cells["Garzon"].Value != null ? this.dgvMesas.SelectedRows[0].Cells["Garzon"].Value.ToString() : "", Convert.ToInt32(this.dgvMesas.SelectedRows[0].Cells["FolioComanda"].Value.ToString())).ShowDialog();
        this.cargaMesas();
      }
      if (!(this.dgvMesas.Columns[e.ColumnIndex].Name == "Liberar"))
        return;
      string str = this.dgvMesas.SelectedRows[0].Cells["Estado"].Value.ToString();
      string _mesa = this.dgvMesas.SelectedRows[0].Cells["NombreMesa"].Value.ToString();
      if (str != "DISPONIBLE")
      {
        if (MessageBox.Show("Esta seguro de Liberar la " + _mesa, "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
          int _folioComanda = Convert.ToInt32(this.dgvMesas.SelectedRows[0].Cells["folioComanda"].Value.ToString());
          this.cambiaEstadoComanda(_mesa, _folioComanda);
          this.cargaMesas();
        }
      }
      else
      {
        int num1 = (int) MessageBox.Show("Esta Mesa ya se ecnuentra Disponible", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
    }

    private void cambiaEstadoComanda(string _mesa, int _folioComanda)
    {
      Comanda comanda = new Comanda();
      string str = "SIN DOCUMENTO";
      Venta veOB = new Venta();
      veOB.FolioDocumentoVenta = 0;
      Boleta boleta = new Boleta();
      int num = 0;
      veOB.Folio = _folioComanda;
      veOB.IDDocumentoVenta = num;
      veOB.DocumentoVenta = str;
      comanda.modificaTipoDocumentoComanda(veOB);
      new Mesa().cambiaEstadoMesa(_mesa, "DISPONIBLE", "0", "");
    }

    private void btnAgregarPedido_Click(object sender, EventArgs e)
    {
      int num = (int) new frmComanda("LLEVAR", "", "", "", 0).ShowDialog();
      this.cargaLLevarDomicilio();
    }

    private void dgvPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (!(this.dgvPedidos.Columns[e.ColumnIndex].Name == "AgregarPedido"))
        return;
      int num = (int) new frmComanda("LLEVAR", "", "", "", Convert.ToInt32(this.dgvPedidos.SelectedRows[0].Cells["Folio"].Value.ToString())).ShowDialog();
      this.cargaLLevarDomicilio();
    }

    private void btnActualizar_Click(object sender, EventArgs e)
    {
      this.cargaMesas();
      this.cargaLLevarDomicilio();
    }

    private void frmAtencionRestaurant_FormClosing(object sender, FormClosingEventArgs e)
    {
      frmMenuPrincipal._modComanda = 0;
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      this.cargaMesas();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle3 = new DataGridViewCellStyle();
      this.dgvMesas = new DataGridView();
      this.IdMesa = new DataGridViewTextBoxColumn();
      this.folioComanda = new DataGridViewTextBoxColumn();
      this.NombreMesa = new DataGridViewTextBoxColumn();
      this.Estado = new DataGridViewTextBoxColumn();
      this.Garzon = new DataGridViewTextBoxColumn();
      this.Seleccionar = new DataGridViewButtonColumn();
      this.Reserva = new DataGridViewButtonColumn();
      this.Liberar = new DataGridViewButtonColumn();
      this.dgvPedidos = new DataGridView();
      this.Folio = new DataGridViewTextBoxColumn();
      this.Numero = new DataGridViewTextBoxColumn();
      this.Cliente = new DataGridViewTextBoxColumn();
      this.Tipo = new DataGridViewTextBoxColumn();
      this.AgregarPedido = new DataGridViewButtonColumn();
      this.btnAgregarPedido = new Button();
      this.btnSalir = new Button();
      this.btnActualizar = new Button();
      this.timer1 = new Timer(this.components);
      this.tabControl1 = new TabControl();
      this.tabPage1 = new TabPage();
      this.tabPage2 = new TabPage();
      this.panel1 = new Panel();
      this.panel2 = new Panel();
      this.panel3 = new Panel();
      this.label1 = new Label();
      this.label2 = new Label();
      this.label3 = new Label();
      ((ISupportInitialize) this.dgvMesas).BeginInit();
      ((ISupportInitialize) this.dgvPedidos).BeginInit();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.SuspendLayout();
      this.dgvMesas.AllowUserToAddRows = false;
      this.dgvMesas.AllowUserToDeleteRows = false;
      this.dgvMesas.AllowUserToResizeColumns = false;
      this.dgvMesas.AllowUserToResizeRows = false;
      gridViewCellStyle1.BackColor = Color.Lavender;
      this.dgvMesas.AlternatingRowsDefaultCellStyle = gridViewCellStyle1;
      this.dgvMesas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvMesas.Columns.AddRange((DataGridViewColumn) this.IdMesa, (DataGridViewColumn) this.folioComanda, (DataGridViewColumn) this.NombreMesa, (DataGridViewColumn) this.Estado, (DataGridViewColumn) this.Garzon, (DataGridViewColumn) this.Seleccionar, (DataGridViewColumn) this.Reserva, (DataGridViewColumn) this.Liberar);
      gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
      gridViewCellStyle2.BackColor = SystemColors.Window;
      gridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      gridViewCellStyle2.ForeColor = SystemColors.ControlText;
      gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle2.WrapMode = DataGridViewTriState.False;
      this.dgvMesas.DefaultCellStyle = gridViewCellStyle2;
      this.dgvMesas.Location = new Point(6, 6);
      this.dgvMesas.Name = "dgvMesas";
      this.dgvMesas.ReadOnly = true;
      this.dgvMesas.RowHeadersVisible = false;
      this.dgvMesas.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Lavender;
      this.dgvMesas.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
      this.dgvMesas.RowTemplate.Height = 32;
      this.dgvMesas.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dgvMesas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvMesas.Size = new Size(697, 585);
      this.dgvMesas.TabIndex = 0;
      this.dgvMesas.CellClick += new DataGridViewCellEventHandler(this.dgvMesas_CellClick);
      this.IdMesa.DataPropertyName = "IdMesa";
      this.IdMesa.HeaderText = "N°";
      this.IdMesa.Name = "IdMesa";
      this.IdMesa.ReadOnly = true;
      this.IdMesa.Resizable = DataGridViewTriState.False;
      this.IdMesa.Visible = false;
      this.IdMesa.Width = 30;
      this.folioComanda.DataPropertyName = "FolioComanda";
      this.folioComanda.HeaderText = "Folio";
      this.folioComanda.Name = "folioComanda";
      this.folioComanda.ReadOnly = true;
      this.folioComanda.Width = 60;
      this.NombreMesa.DataPropertyName = "NombreMesa";
      this.NombreMesa.HeaderText = "Mesa";
      this.NombreMesa.Name = "NombreMesa";
      this.NombreMesa.ReadOnly = true;
      this.NombreMesa.Resizable = DataGridViewTriState.False;
      this.Estado.DataPropertyName = "Estado";
      this.Estado.HeaderText = "Estado";
      this.Estado.Name = "Estado";
      this.Estado.ReadOnly = true;
      this.Estado.Resizable = DataGridViewTriState.False;
      this.Garzon.DataPropertyName = "Garzon";
      this.Garzon.HeaderText = "Garzon";
      this.Garzon.Name = "Garzon";
      this.Garzon.ReadOnly = true;
      this.Garzon.Resizable = DataGridViewTriState.False;
      this.Garzon.Width = 110;
      this.Seleccionar.HeaderText = "Comanda";
      this.Seleccionar.Name = "Seleccionar";
      this.Seleccionar.ReadOnly = true;
      this.Seleccionar.Text = "COMANDA";
      this.Seleccionar.UseColumnTextForButtonValue = true;
      this.Reserva.HeaderText = "Reserva";
      this.Reserva.Name = "Reserva";
      this.Reserva.ReadOnly = true;
      this.Reserva.Text = "RESERVA";
      this.Reserva.UseColumnTextForButtonValue = true;
      this.Liberar.HeaderText = "Liberar";
      this.Liberar.Name = "Liberar";
      this.Liberar.ReadOnly = true;
      this.Liberar.Text = "LIBERAR MESA";
      this.Liberar.UseColumnTextForButtonValue = true;
      this.dgvPedidos.AllowUserToAddRows = false;
      this.dgvPedidos.AllowUserToDeleteRows = false;
      this.dgvPedidos.BorderStyle = BorderStyle.Fixed3D;
      this.dgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvPedidos.Columns.AddRange((DataGridViewColumn) this.Folio, (DataGridViewColumn) this.Numero, (DataGridViewColumn) this.Cliente, (DataGridViewColumn) this.Tipo, (DataGridViewColumn) this.AgregarPedido);
      this.dgvPedidos.Location = new Point(6, 6);
      this.dgvPedidos.Name = "dgvPedidos";
      this.dgvPedidos.ReadOnly = true;
      this.dgvPedidos.RowHeadersVisible = false;
      this.dgvPedidos.RowTemplate.Height = 32;
      this.dgvPedidos.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dgvPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvPedidos.Size = new Size(517, 541);
      this.dgvPedidos.TabIndex = 1;
      this.dgvPedidos.CellClick += new DataGridViewCellEventHandler(this.dgvPedidos_CellClick);
      this.Folio.DataPropertyName = "Folio";
      this.Folio.HeaderText = "Folio";
      this.Folio.Name = "Folio";
      this.Folio.ReadOnly = true;
      this.Folio.Width = 50;
      this.Numero.DataPropertyName = "FechaEmision";
      gridViewCellStyle3.Format = "T";
      gridViewCellStyle3.NullValue = (object) null;
      this.Numero.DefaultCellStyle = gridViewCellStyle3;
      this.Numero.HeaderText = "Hora";
      this.Numero.Name = "Numero";
      this.Numero.ReadOnly = true;
      this.Numero.Resizable = DataGridViewTriState.False;
      this.Numero.Width = 80;
      this.Cliente.DataPropertyName = "RazonSocial";
      this.Cliente.HeaderText = "Cliente";
      this.Cliente.Name = "Cliente";
      this.Cliente.ReadOnly = true;
      this.Cliente.Resizable = DataGridViewTriState.False;
      this.Cliente.Width = 215;
      this.Tipo.DataPropertyName = "Mesa";
      this.Tipo.HeaderText = "Tipo";
      this.Tipo.Name = "Tipo";
      this.Tipo.ReadOnly = true;
      this.Tipo.Resizable = DataGridViewTriState.False;
      this.AgregarPedido.HeaderText = "Selec.";
      this.AgregarPedido.Name = "AgregarPedido";
      this.AgregarPedido.ReadOnly = true;
      this.AgregarPedido.Resizable = DataGridViewTriState.False;
      this.AgregarPedido.Text = "+";
      this.AgregarPedido.UseColumnTextForButtonValue = true;
      this.AgregarPedido.Width = 50;
      this.btnAgregarPedido.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnAgregarPedido.Location = new Point(529, 6);
      this.btnAgregarPedido.Name = "btnAgregarPedido";
      this.btnAgregarPedido.Size = new Size(184, 36);
      this.btnAgregarPedido.TabIndex = 0;
      this.btnAgregarPedido.Text = "Agregar Pedido";
      this.btnAgregarPedido.UseVisualStyleBackColor = true;
      this.btnAgregarPedido.Click += new EventHandler(this.btnAgregarPedido_Click);
      this.btnSalir.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnSalir.Location = new Point(917, 641);
      this.btnSalir.Name = "btnSalir";
      this.btnSalir.Size = new Size(75, 51);
      this.btnSalir.TabIndex = 2;
      this.btnSalir.Text = "Salir";
      this.btnSalir.UseVisualStyleBackColor = true;
      this.btnSalir.Click += new EventHandler(this.btnSalir_Click);
      this.btnActualizar.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnActualizar.Location = new Point(762, 6);
      this.btnActualizar.Name = "btnActualizar";
      this.btnActualizar.Size = new Size(204, 36);
      this.btnActualizar.TabIndex = 3;
      this.btnActualizar.Text = "Actualizar Mesas";
      this.btnActualizar.UseVisualStyleBackColor = true;
      this.btnActualizar.Click += new EventHandler(this.btnActualizar_Click);
      this.timer1.Interval = 60000;
      this.timer1.Tick += new EventHandler(this.timer1_Tick);
      this.tabControl1.Controls.Add((Control) this.tabPage1);
      this.tabControl1.Controls.Add((Control) this.tabPage2);
      this.tabControl1.Location = new Point(12, 12);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new Size(980, 623);
      this.tabControl1.TabIndex = 3;
      this.tabPage1.Controls.Add((Control) this.label3);
      this.tabPage1.Controls.Add((Control) this.label2);
      this.tabPage1.Controls.Add((Control) this.label1);
      this.tabPage1.Controls.Add((Control) this.panel3);
      this.tabPage1.Controls.Add((Control) this.panel2);
      this.tabPage1.Controls.Add((Control) this.panel1);
      this.tabPage1.Controls.Add((Control) this.dgvMesas);
      this.tabPage1.Controls.Add((Control) this.btnActualizar);
      this.tabPage1.Location = new Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new Padding(3);
      this.tabPage1.Size = new Size(972, 597);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "ATENCION MESAS";
      this.tabPage1.UseVisualStyleBackColor = true;
      this.tabPage2.Controls.Add((Control) this.dgvPedidos);
      this.tabPage2.Controls.Add((Control) this.btnAgregarPedido);
      this.tabPage2.Location = new Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new Padding(3);
      this.tabPage2.Size = new Size(972, 597);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "PARA LLEVAR Y DOMICILIO";
      this.tabPage2.UseVisualStyleBackColor = true;
      this.panel1.BackColor = Color.Red;
      this.panel1.Location = new Point(709, 529);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(121, 28);
      this.panel1.TabIndex = 4;
      this.panel2.BackColor = Color.GreenYellow;
      this.panel2.Location = new Point(709, 495);
      this.panel2.Name = "panel2";
      this.panel2.Size = new Size(121, 28);
      this.panel2.TabIndex = 5;
      this.panel3.BackColor = Color.Orange;
      this.panel3.Location = new Point(709, 563);
      this.panel3.Name = "panel3";
      this.panel3.Size = new Size(121, 28);
      this.panel3.TabIndex = 6;
      this.label1.AutoSize = true;
      this.label1.Location = new Point(834, 503);
      this.label1.Name = "label1";
      this.label1.Size = new Size(71, 13);
      this.label1.TabIndex = 7;
      this.label1.Text = "DISPONIBLE";
      this.label2.AutoSize = true;
      this.label2.Location = new Point(834, 537);
      this.label2.Name = "label2";
      this.label2.Size = new Size(59, 13);
      this.label2.TabIndex = 8;
      this.label2.Text = "OCUPADA";
      this.label3.AutoSize = true;
      this.label3.Location = new Point(834, 571);
      this.label3.Name = "label3";
      this.label3.Size = new Size(73, 13);
      this.label3.TabIndex = 9;
      this.label3.Text = "RESERVADA";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
//      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(223, 233, 245);
      this.ClientSize = new Size(1018, 751);
      this.Controls.Add((Control) this.tabControl1);
      this.Controls.Add((Control) this.btnSalir);
//      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.Name = "frmAtencionRestaurant";
      this.ShowIcon = false;
      this.Text = "Atención Restaurant";
      this.WindowState = FormWindowState.Maximized;
      this.FormClosing += new FormClosingEventHandler(this.frmAtencionRestaurant_FormClosing);
      this.Load += new EventHandler(this.frmAtencionRestaurant_Load);
      ((ISupportInitialize) this.dgvMesas).EndInit();
      ((ISupportInitialize) this.dgvPedidos).EndInit();
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage1.PerformLayout();
      this.tabPage2.ResumeLayout(false);
      this.ResumeLayout(false);
    }
  }
}
