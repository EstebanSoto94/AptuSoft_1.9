 
// Type: Aptusoft.frmBuscaProveedor
 
 
// version 1.8.0

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Aptusoft
{
  public class frmBuscaProveedor : Form
  {
    private IContainer components = (IContainer) null;
    private frmProveedor frmPro = (frmProveedor) null;
    private frmIngresoCompra frmIC = (frmIngresoCompra) null;
    private frmOrdenCompra frmOC = (frmOrdenCompra) null;
    private frmLanzadorInformesCompras frmLIC = (frmLanzadorInformesCompras) null;
    private frmLanzaInformeInventario frmLII = (frmLanzaInformeInventario) null;
    private Label label1;
    private TextBox txtClienteBuscar;
    private Button btnBuscar;
    private DataGridView dgvClientes;
    private Button btnSalir;
    private Label label2;
    private ComboBox cmbSeleccionaItemBuscar;
    private string modulo;

    public frmBuscaProveedor(ref frmProveedor p, string modulo)
    {
      this.InitializeComponent();
      this.cargaTipoBusqueda();
      this.frmPro = p;
      this.creaColumnas();
      this.modulo = modulo;
    }

    public frmBuscaProveedor(ref frmIngresoCompra ic, string modulo)
    {
      this.InitializeComponent();
      this.cargaTipoBusqueda();
      this.frmIC = ic;
      this.creaColumnas();
      this.modulo = modulo;
    }

    public frmBuscaProveedor(ref frmOrdenCompra oc, string modulo)
    {
      this.InitializeComponent();
      this.cargaTipoBusqueda();
      this.frmOC = oc;
      this.creaColumnas();
      this.modulo = modulo;
    }

    public frmBuscaProveedor(ref frmLanzadorInformesCompras lic, string modulo)
    {
      this.InitializeComponent();
      this.cargaTipoBusqueda();
      this.frmLIC = lic;
      this.creaColumnas();
      this.modulo = modulo;
    }
 
    public frmBuscaProveedor(ref frmLanzaInformeInventario lii, string modulo)
    {
      this.InitializeComponent();
      this.cargaTipoBusqueda();
      this.frmLII = lii;
      this.creaColumnas();
      this.modulo = modulo;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.label1 = new Label();
      this.txtClienteBuscar = new TextBox();
      this.btnBuscar = new Button();
      this.dgvClientes = new DataGridView();
      this.btnSalir = new Button();
      this.label2 = new Label();
      this.cmbSeleccionaItemBuscar = new ComboBox();
      ((ISupportInitialize) this.dgvClientes).BeginInit();
      this.SuspendLayout();
      this.label1.BackColor = Color.FromArgb(64, 64, 64);
      this.label1.Font = new Font("Verdana", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label1.ForeColor = Color.White;
      this.label1.Location = new Point(9, 9);
      this.label1.Name = "label1";
      this.label1.Size = new Size(417, 17);
      this.label1.TabIndex = 0;
      this.label1.Text = "Ingrese Proveedor a Buscar";
      this.txtClienteBuscar.Location = new Point(9, 26);
      this.txtClienteBuscar.Name = "txtClienteBuscar";
      this.txtClienteBuscar.Size = new Size(417, 20);
      this.txtClienteBuscar.TabIndex = 1;
      this.txtClienteBuscar.KeyDown += new KeyEventHandler(this.txtClienteBuscar_KeyDown);
      this.txtClienteBuscar.KeyPress += new KeyPressEventHandler(this.txtClienteBuscar_KeyPress);
      this.btnBuscar.Location = new Point(432, 6);
      this.btnBuscar.Name = "btnBuscar";
      this.btnBuscar.Size = new Size(75, 40);
      this.btnBuscar.TabIndex = 2;
      this.btnBuscar.Text = "Buscar";
      this.btnBuscar.UseVisualStyleBackColor = true;
      this.btnBuscar.Click += new EventHandler(this.btnBuscar_Click);
      this.dgvClientes.AllowUserToAddRows = false;
      this.dgvClientes.AllowUserToDeleteRows = false;
      this.dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      this.dgvClientes.Location = new Point(9, 78);
      this.dgvClientes.Name = "dgvClientes";
      this.dgvClientes.ReadOnly = true;
      this.dgvClientes.RowHeadersVisible = false;
      this.dgvClientes.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvClientes.Size = new Size(907, 323);
      this.dgvClientes.TabIndex = 3;
      this.dgvClientes.CellDoubleClick += new DataGridViewCellEventHandler(this.dgvClienteBusca_CellDoubleClick);
      this.dgvClientes.KeyDown += new KeyEventHandler(this.dgvClientes_KeyDown);
      this.dgvClientes.KeyPress += new KeyPressEventHandler(this.dgvClientes_KeyPress);
      this.btnSalir.Location = new Point(513, 6);
      this.btnSalir.Name = "btnSalir";
      this.btnSalir.Size = new Size(75, 40);
      this.btnSalir.TabIndex = 7;
      this.btnSalir.Text = "Salir";
      this.btnSalir.UseVisualStyleBackColor = true;
      this.btnSalir.Click += new EventHandler(this.btnSalir_Click);
      this.label2.AutoSize = true;
      this.label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label2.Location = new Point(12, 54);
      this.label2.Name = "label2";
      this.label2.Size = new Size(88, 16);
      this.label2.TabIndex = 12;
      this.label2.Text = "Buscar Por:";
      this.cmbSeleccionaItemBuscar.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbSeleccionaItemBuscar.FormattingEnabled = true;
      this.cmbSeleccionaItemBuscar.Location = new Point(105, 52);
      this.cmbSeleccionaItemBuscar.Name = "cmbSeleccionaItemBuscar";
      this.cmbSeleccionaItemBuscar.Size = new Size(173, 21);
      this.cmbSeleccionaItemBuscar.TabIndex = 11;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(223, 233, 245);
      this.ClientSize = new Size(928, 409);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.cmbSeleccionaItemBuscar);
      this.Controls.Add((Control) this.btnSalir);
      this.Controls.Add((Control) this.dgvClientes);
      this.Controls.Add((Control) this.btnBuscar);
      this.Controls.Add((Control) this.txtClienteBuscar);
      this.Controls.Add((Control) this.label1);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "frmBuscaProveedor";
      this.ShowIcon = false;
      this.Text = "Buscador de Proveedores";
      ((ISupportInitialize) this.dgvClientes).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private void cargaTipoBusqueda()
    {
      CargaMaestros cargaMaestros = new CargaMaestros();
      List<BodegaVO> list = new List<BodegaVO>();
      this.cmbSeleccionaItemBuscar.DataSource = (object) cargaMaestros.cargaTipoBusquedaClientePro();
      this.cmbSeleccionaItemBuscar.ValueMember = "IdBodega";
      this.cmbSeleccionaItemBuscar.DisplayMember = "nombreBodega";
      this.cmbSeleccionaItemBuscar.SelectedValue = (object) 1;
    }

    private void creaColumnas()
    {
      this.dgvClientes.AutoGenerateColumns = false;
      this.dgvClientes.Columns.Add("Codigo", "Cod.");
      this.dgvClientes.Columns[0].DataPropertyName = "Codigo";
      this.dgvClientes.Columns[0].Width = 35;
      this.dgvClientes.Columns[0].Resizable = DataGridViewTriState.False;
      this.dgvClientes.Columns.Add("Rut", "Rut");
      this.dgvClientes.Columns[1].DataPropertyName = "Rut";
      this.dgvClientes.Columns[1].Width = 80;
      this.dgvClientes.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvClientes.Columns[1].Resizable = DataGridViewTriState.False;
      this.dgvClientes.Columns.Add("Digito", "");
      this.dgvClientes.Columns[2].DataPropertyName = "Digito";
      this.dgvClientes.Columns[2].Width = 20;
      this.dgvClientes.Columns[2].Resizable = DataGridViewTriState.False;
      this.dgvClientes.Columns.Add("RazonSocial", "Razon Social");
      this.dgvClientes.Columns[3].DataPropertyName = "RazonSocial";
      this.dgvClientes.Columns[3].Width = 270;
      this.dgvClientes.Columns[3].Resizable = DataGridViewTriState.False;
      this.dgvClientes.Columns.Add("Direccion", "Direccion");
      this.dgvClientes.Columns[4].DataPropertyName = "Direccion";
      this.dgvClientes.Columns[4].Width = 220;
      this.dgvClientes.Columns[4].Resizable = DataGridViewTriState.False;
      this.dgvClientes.Columns.Add("Ciudad", "Ciudad");
      this.dgvClientes.Columns[5].DataPropertyName = "Ciudad";
      this.dgvClientes.Columns[5].Width = 130;
      this.dgvClientes.Columns[5].Resizable = DataGridViewTriState.False;
      this.dgvClientes.Columns.Add("Comuna", "Comuna");
      this.dgvClientes.Columns[6].DataPropertyName = "Comuna";
      this.dgvClientes.Columns[6].Width = 130;
      this.dgvClientes.Columns[6].Resizable = DataGridViewTriState.False;
    }

    private void btnBuscar_Click(object sender, EventArgs e)
    {
      this.buscaProveedorNombre();
    }

    private void buscaProveedorNombre()
    {
      List<ClienteVO> list = new Proveedor().buscaProveedorDato(Convert.ToInt32(this.cmbSeleccionaItemBuscar.SelectedValue.ToString()), this.txtClienteBuscar.Text.Trim());
      if (list.Count > 0)
      {
        this.dgvClientes.DataSource = (object) list;
      }
      else
      {
        int num = (int) MessageBox.Show("No existe Proveedor Consultado");
        this.txtClienteBuscar.Focus();
      }
    }

    private void dgvClienteBusca_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      int cod = Convert.ToInt32(this.dgvClientes.SelectedRows[0].Cells[0].Value.ToString());
      if (this.modulo.Equals("proveedor"))
      {
        this.frmPro.buscaProveedorCodigo(cod);
        this.Close();
      }
      if (this.modulo.Equals("compra"))
      {
        try
        {
          this.frmIC.buscaProveedorCodigo(cod);
          this.Close();
        }
        catch (Exception ex)
        {
          int num = (int) MessageBox.Show("Error al buscar : " + ex.Message);
        }
      }
      if (this.modulo.Equals("orden_compra"))
      {
        try
        {
          this.frmOC.buscaProveedorCodigo(cod);
          this.Close();
        }
        catch (Exception ex)
        {
          int num = (int) MessageBox.Show("Error al buscar : " + ex.Message);
        }
      }
      if (this.modulo.Equals("informe_compras"))
      {
        try
        {
          this.frmLIC.buscaProveedorCodigo(cod);
          this.Close();
        }
        catch (Exception ex)
        {
          int num = (int) MessageBox.Show("Error al buscar : " + ex.Message);
        }
      }
      if (!this.modulo.Equals("informe_inventario"))
        return;
      try
      {
        this.frmLII.buscaProveedorCodigo(cod);
        this.Close();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al buscar : " + ex.Message);
      }
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void txtClienteBuscar_KeyPress(object sender, KeyPressEventArgs e)
    {
      if ((int) e.KeyChar != 13)
        return;
      e.Handled = false;
      this.buscaProveedorNombre();
    }

    private void txtClienteBuscar_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Down)
        return;
      this.dgvClientes.Focus();
    }

    private void dgvClientes_KeyPress(object sender, KeyPressEventArgs e)
    {
    }

    private void dgvClientes_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      int cod = Convert.ToInt32(this.dgvClientes.SelectedRows[0].Cells[0].Value.ToString());
      if (this.modulo.Equals("proveedor"))
      {
        this.frmPro.buscaProveedorCodigo(cod);
        this.Close();
      }
      if (this.modulo.Equals("compra"))
      {
        try
        {
          this.frmIC.buscaProveedorCodigo(cod);
          this.Close();
        }
        catch (Exception ex)
        {
          int num = (int) MessageBox.Show("Error al buscar : " + ex.Message);
        }
      }
      if (this.modulo.Equals("orden_compra"))
      {
        try
        {
          this.frmOC.buscaProveedorCodigo(cod);
          this.Close();
        }
        catch (Exception ex)
        {
          int num = (int) MessageBox.Show("Error al buscar : " + ex.Message);
        }
      }
      if (this.modulo.Equals("informe_compras"))
      {
        try
        {
          this.frmLIC.buscaProveedorCodigo(cod);
          this.Close();
        }
        catch (Exception ex)
        {
          int num = (int) MessageBox.Show("Error al buscar : " + ex.Message);
        }
      }
      if (this.modulo.Equals("informe_inventario"))
      {
        try
        {
          this.frmLII.buscaProveedorCodigo(cod);
          this.Close();
        }
        catch (Exception ex)
        {
          int num = (int) MessageBox.Show("Error al buscar : " + ex.Message);
        }
      }
    }
  }
}
