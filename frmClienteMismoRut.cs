 
// Type: Aptusoft.frmClienteMismoRut
 
 
// version 1.8.0

using Aptusoft.FacturaElectronica.Formularios;
using Aptusoft.InternoAptusoft.Contratacion;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Aptusoft
{
  public class frmClienteMismoRut : Form
  {
    private frmClientes frmCli = (frmClientes) null;
    private frmFactura frmFac = (frmFactura) null;
    private frmFacturaExenta frmFacExe = (frmFacturaExenta) null;
    private frmTicket frmTic = (frmTicket) null;
    private frmBoleta frmBol = (frmBoleta) null;
    private frmBoletaFiscal frmBolFis = (frmBoletaFiscal) null;
    private frmGuiaDespacho frmGui = (frmGuiaDespacho) null;
    private frmNotaCredito frmNC = (frmNotaCredito) null;
    private frmCotizacion frmCoti = (frmCotizacion) null;
    private frmLanzadorInformesVenta frmIFV = (frmLanzadorInformesVenta) null;
    private frmFacturaGuias frmFacGui = (frmFacturaGuias) null;
    private frmNotaVenta frmNotVen = (frmNotaVenta) null;
    private frmOrdenAtencion frmOrdAte = (frmOrdenAtencion) null;
    private frmOrdenTrabajo frmOt = (frmOrdenTrabajo) null;
    private frmComanda frmComa = (frmComanda) null;
    private frmModuloFacturacionAptusoft frmMFF = (frmModuloFacturacionAptusoft) null;
    private frmFacturaElectronica frmFacElectronic = (frmFacturaElectronica) null;
    private frmFacturaElectronicaFrigo frmFacElecFrigo = (frmFacturaElectronicaFrigo)null;
    private frmFacturaExentaElectronica frmFacExeElectronic = (frmFacturaExentaElectronica) null;
    private frmNotaCreditoElectronica frmNCElectronic = (frmNotaCreditoElectronica) null;
    private frmNotaDebitoElectronica frmNDElectronic = (frmNotaDebitoElectronica) null;
    private frmGuiaDespachoElectronica frmGuiaElectronic = (frmGuiaDespachoElectronica) null;
    private frmBoletaElectronica frmBolElectronic = (frmBoletaElectronica) null;
    private frmContratacion frmContra = (frmContratacion) null;
    private IContainer components = (IContainer) null;
    private string modulo;
    private DataGridView dgvClientes;

    public frmClienteMismoRut(ArrayList cli, ref frmClientes f, string modulo)
    {
      this.InitializeComponent();
      this.frmCli = f;
      this.creaColumnas();
      this.dgvClientes.DataSource = (object) cli;
      this.modulo = modulo;
    }

    public frmClienteMismoRut(ArrayList cli, ref frmContratacion c, string modulo)
    {
      this.InitializeComponent();
      this.frmContra = c;
      this.creaColumnas();
      this.dgvClientes.DataSource = (object) cli;
      this.modulo = modulo;
    }

    public frmClienteMismoRut(ArrayList cli, ref frmFacturaElectronica f, string modulo)
    {
      this.InitializeComponent();
      this.frmFacElectronic = f;
      this.creaColumnas();
      this.dgvClientes.DataSource = (object) cli;
      this.modulo = modulo;
    }

    public frmClienteMismoRut(ArrayList cli, ref frmFacturaElectronicaFrigo f, string modulo)
    {
        this.InitializeComponent();
        this.frmFacElecFrigo = f;
        this.creaColumnas();
        this.dgvClientes.DataSource = (object)cli;
        this.modulo = modulo;
    }

    public frmClienteMismoRut(ArrayList cli, ref frmFacturaExentaElectronica fe, string modulo)
    {
      this.InitializeComponent();
      this.frmFacExeElectronic = fe;
      this.creaColumnas();
      this.dgvClientes.DataSource = (object) cli;
      this.modulo = modulo;
    }

    public frmClienteMismoRut(ArrayList cli, ref frmNotaCreditoElectronica f, string modulo)
    {
      this.InitializeComponent();
      this.frmNCElectronic = f;
      this.creaColumnas();
      this.dgvClientes.DataSource = (object) cli;
      this.modulo = modulo;
    }

    public frmClienteMismoRut(ArrayList cli, ref frmNotaDebitoElectronica f, string modulo)
    {
      this.InitializeComponent();
      this.frmNDElectronic = f;
      this.creaColumnas();
      this.dgvClientes.DataSource = (object) cli;
      this.modulo = modulo;
    }

    public frmClienteMismoRut(ArrayList cli, ref frmGuiaDespachoElectronica g, string modulo)
    {
      this.InitializeComponent();
      this.frmGuiaElectronic = g;
      this.creaColumnas();
      this.dgvClientes.DataSource = (object) cli;
      this.modulo = modulo;
    }

    public frmClienteMismoRut(ArrayList cli, ref frmBoletaElectronica b, string modulo)
    {
      this.InitializeComponent();
      this.frmBolElectronic = b;
      this.creaColumnas();
      this.dgvClientes.DataSource = (object) cli;
      this.modulo = modulo;
    }

    public frmClienteMismoRut(ArrayList cli, ref frmOrdenAtencion oa, string modulo)
    {
      this.InitializeComponent();
      this.frmOrdAte = oa;
      this.creaColumnas();
      this.dgvClientes.DataSource = (object) cli;
      this.modulo = modulo;
    }

    public frmClienteMismoRut(ArrayList cli, ref frmFactura f, string modulo)
    {
      this.InitializeComponent();
      this.frmFac = f;
      this.creaColumnas();
      this.dgvClientes.DataSource = (object) cli;
      this.modulo = modulo;
    }

    public frmClienteMismoRut(ArrayList cli, ref frmFacturaExenta fe, string modulo)
    {
      this.InitializeComponent();
      this.frmFacExe = fe;
      this.creaColumnas();
      this.dgvClientes.DataSource = (object) cli;
      this.modulo = modulo;
    }

    public frmClienteMismoRut(ArrayList cli, ref frmNotaVenta n, string modulo)
    {
      this.InitializeComponent();
      this.frmNotVen = n;
      this.creaColumnas();
      this.dgvClientes.DataSource = (object) cli;
      this.modulo = modulo;
    }

    public frmClienteMismoRut(ArrayList cli, ref frmTicket t, string modulo)
    {
      this.InitializeComponent();
      this.frmTic = t;
      this.creaColumnas();
      this.dgvClientes.DataSource = (object) cli;
      this.modulo = modulo;
    }

    public frmClienteMismoRut(ArrayList cli, ref frmBoleta b, string modulo)
    {
      this.InitializeComponent();
      this.frmBol = b;
      this.creaColumnas();
      this.dgvClientes.DataSource = (object) cli;
      this.modulo = modulo;
    }

    public frmClienteMismoRut(ArrayList cli, ref frmBoletaFiscal b, string modulo)
    {
      this.InitializeComponent();
      this.frmBolFis = b;
      this.creaColumnas();
      this.dgvClientes.DataSource = (object) cli;
      this.modulo = modulo;
    }

    public frmClienteMismoRut(ArrayList cli, ref frmGuiaDespacho g, string modulo)
    {
      this.InitializeComponent();
      this.frmGui = g;
      this.creaColumnas();
      this.dgvClientes.DataSource = (object) cli;
      this.modulo = modulo;
    }

    public frmClienteMismoRut(ArrayList cli, ref frmNotaCredito nc, string modulo)
    {
      this.InitializeComponent();
      this.frmNC = nc;
      this.creaColumnas();
      this.dgvClientes.DataSource = (object) cli;
      this.modulo = modulo;
    }

    public frmClienteMismoRut(ArrayList cli, ref frmCotizacion coti, string modulo)
    {
      this.InitializeComponent();
      this.frmCoti = coti;
      this.creaColumnas();
      this.dgvClientes.DataSource = (object) cli;
      this.modulo = modulo;
    }

    public frmClienteMismoRut(ArrayList cli, ref frmLanzadorInformesVenta ifv, string modulo)
    {
      this.InitializeComponent();
      this.frmIFV = ifv;
      this.creaColumnas();
      this.dgvClientes.DataSource = (object) cli;
      this.modulo = modulo;
    }

    public frmClienteMismoRut(ArrayList cli, ref frmFacturaGuias fg, string modulo)
    {
      this.InitializeComponent();
      this.frmFacGui = fg;
      this.creaColumnas();
      this.dgvClientes.DataSource = (object) cli;
      this.modulo = modulo;
    }

    public frmClienteMismoRut(ArrayList cli, ref frmOrdenTrabajo ot, string modulo)
    {
      this.InitializeComponent();
      this.frmOt = ot;
      this.creaColumnas();
      this.dgvClientes.DataSource = (object) cli;
      this.modulo = modulo;
    }

    public frmClienteMismoRut(ArrayList cli, ref frmComanda co, string modulo)
    {
      this.InitializeComponent();
      this.frmComa = co;
      this.creaColumnas();
      this.dgvClientes.DataSource = (object) cli;
      this.modulo = modulo;
    }

    public frmClienteMismoRut(ArrayList cli, ref frmModuloFacturacionAptusoft mff, string modulo)
    {
      this.InitializeComponent();
      this.frmMFF = mff;
      this.creaColumnas();
      this.dgvClientes.DataSource = (object) cli;
      this.modulo = modulo;
    }

    private void creaColumnas()
    {
      this.dgvClientes.AutoGenerateColumns = false;
      this.dgvClientes.Columns.Add("Codigo", "Cod.");
      this.dgvClientes.Columns[0].DataPropertyName = "Codigo";
      this.dgvClientes.Columns[0].Width = 30;
      this.dgvClientes.Columns.Add("Rut", "Rut");
      this.dgvClientes.Columns[1].DataPropertyName = "Rut";
      this.dgvClientes.Columns[1].Width = 80;
      this.dgvClientes.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvClientes.Columns.Add("Digito", "");
      this.dgvClientes.Columns[2].DataPropertyName = "Digito";
      this.dgvClientes.Columns[2].Width = 20;
      this.dgvClientes.Columns.Add("RazonSocial", "Razon Social");
      this.dgvClientes.Columns[3].DataPropertyName = "RazonSocial";
      this.dgvClientes.Columns[3].Width = 200;
      this.dgvClientes.Columns.Add("Direccion", "Direccion");
      this.dgvClientes.Columns[4].DataPropertyName = "Direccion";
      this.dgvClientes.Columns[4].Width = 200;
      this.dgvClientes.Columns.Add("Ciudad", "Ciudad");
      this.dgvClientes.Columns[5].DataPropertyName = "Ciudad";
      this.dgvClientes.Columns[5].Width = 130;
      this.dgvClientes.Columns.Add("Comuna", "Comuna");
      this.dgvClientes.Columns[6].DataPropertyName = "Comuna";
      this.dgvClientes.Columns[6].Width = 130;
    }

    private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.modulo.Equals("cliente"))
      {
        this.frmCli.buscaClienteCodigo(Convert.ToInt32(this.dgvClientes.SelectedRows[0].Cells[0].Value.ToString()));
        this.Close();
      }
      if (this.modulo.Equals("factura"))
      {
        this.frmFac.buscaClienteCodigo(Convert.ToInt32(this.dgvClientes.SelectedRows[0].Cells[0].Value.ToString()));
        this.Close();
      }
      if (this.modulo.Equals("contratacion"))
      {
        this.frmContra.buscaClienteCodigo(Convert.ToInt32(this.dgvClientes.SelectedRows[0].Cells[0].Value.ToString()));
        this.Close();
      }
      if (this.modulo.Equals("factura_electronica"))
      {
        this.frmFacElectronic.buscaClienteCodigo(Convert.ToInt32(this.dgvClientes.SelectedRows[0].Cells[0].Value.ToString()));
        this.Close();
      }
      if (this.modulo.Equals("factura_exenta_electronica"))
      {
        this.frmFacExeElectronic.buscaClienteCodigo(Convert.ToInt32(this.dgvClientes.SelectedRows[0].Cells[0].Value.ToString()));
        this.Close();
      }
      if (this.modulo.Equals("nota_credito_electronica"))
      {
        this.frmNCElectronic.buscaClienteCodigo(Convert.ToInt32(this.dgvClientes.SelectedRows[0].Cells[0].Value.ToString()));
        this.Close();
      }
      if (this.modulo.Equals("nota_debito_electronica"))
      {
        this.frmNDElectronic.buscaClienteCodigo(Convert.ToInt32(this.dgvClientes.SelectedRows[0].Cells[0].Value.ToString()));
        this.Close();
      }
      if (this.modulo.Equals("guia_electronica"))
      {
        this.frmGuiaElectronic.buscaClienteCodigo(Convert.ToInt32(this.dgvClientes.SelectedRows[0].Cells[0].Value.ToString()));
        this.Close();
      }
      if (this.modulo.Equals("boleta_electronica"))
      {
        this.frmBolElectronic.buscaClienteCodigo(Convert.ToInt32(this.dgvClientes.SelectedRows[0].Cells[0].Value.ToString()));
        this.Close();
      }
      if (this.modulo.Equals("factura_exenta"))
      {
        this.frmFacExe.buscaClienteCodigo(Convert.ToInt32(this.dgvClientes.SelectedRows[0].Cells[0].Value.ToString()));
        this.Close();
      }
      if (this.modulo.Equals("informe_factura"))
      {
        try
        {
          this.frmIFV.buscaClienteCodigo(Convert.ToInt32(this.dgvClientes.SelectedRows[0].Cells[0].Value.ToString()));
          this.Close();
        }
        catch (Exception ex)
        {
          int num = (int) MessageBox.Show("error " + ex.Message);
        }
      }
      if (this.modulo.Equals("ticket"))
      {
        this.frmTic.buscaClienteCodigo(Convert.ToInt32(this.dgvClientes.SelectedRows[0].Cells[0].Value.ToString()));
        this.Close();
      }
      if (this.modulo.Equals("boleta"))
      {
        this.frmBol.buscaClienteCodigo(Convert.ToInt32(this.dgvClientes.SelectedRows[0].Cells[0].Value.ToString()));
        this.Close();
      }
      if (this.modulo.Equals("boleta_fiscal"))
      {
        this.frmBolFis.buscaClienteCodigo(Convert.ToInt32(this.dgvClientes.SelectedRows[0].Cells[0].Value.ToString()));
        this.Close();
      }
      if (this.modulo.Equals("guia"))
      {
        this.frmGui.buscaClienteCodigo(Convert.ToInt32(this.dgvClientes.SelectedRows[0].Cells[0].Value.ToString()));
        this.Close();
      }
      if (this.modulo.Equals("notaCredito"))
      {
        this.frmNC.buscaClienteCodigo(Convert.ToInt32(this.dgvClientes.SelectedRows[0].Cells[0].Value.ToString()));
        this.Close();
      }
      if (this.modulo.Equals("nota_venta"))
      {
        this.frmNotVen.buscaClienteCodigo(Convert.ToInt32(this.dgvClientes.SelectedRows[0].Cells[0].Value.ToString()));
        this.Close();
      }
      if (this.modulo.Equals("cotizacion"))
      {
        this.frmCoti.buscaClienteCodigo(Convert.ToInt32(this.dgvClientes.SelectedRows[0].Cells[0].Value.ToString()));
        this.Close();
      }
      if (this.modulo.Equals("factura_guias"))
      {
        this.frmFacGui.buscaClienteCodigo(Convert.ToInt32(this.dgvClientes.SelectedRows[0].Cells[0].Value.ToString()));
        this.Close();
      }
      if (this.modulo.Equals("orden_atencion"))
      {
        this.frmOrdAte.buscaClienteCodigo(Convert.ToInt32(this.dgvClientes.SelectedRows[0].Cells[0].Value.ToString()));
        this.Close();
      }
      if (this.modulo.Equals("ordenTrabajo"))
      {
        this.frmOt.buscaClienteCodigo(Convert.ToInt32(this.dgvClientes.SelectedRows[0].Cells[0].Value.ToString()));
        this.Close();
      }
      if (this.modulo.Equals("comanda"))
      {
        this.frmComa.buscaClienteCodigo(Convert.ToInt32(this.dgvClientes.SelectedRows[0].Cells[0].Value.ToString()));
        this.Close();
      }
      if (!this.modulo.Equals("modulo_facturacion_Aptusoft"))
        return;
      this.frmMFF.buscaClienteCodigo(Convert.ToInt32(this.dgvClientes.SelectedRows[0].Cells[0].Value.ToString()));
      this.Close();
    }

    private void dgvClientes_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      if (this.modulo.Equals("cliente"))
      {
        this.frmCli.buscaClienteCodigo(Convert.ToInt32(this.dgvClientes.SelectedRows[0].Cells[0].Value.ToString()));
        this.Close();
      }
      if (this.modulo.Equals("factura"))
      {
        this.frmFac.buscaClienteCodigo(Convert.ToInt32(this.dgvClientes.SelectedRows[0].Cells[0].Value.ToString()));
        this.Close();
      }
      if (this.modulo.Equals("contratacion"))
      {
        this.frmContra.buscaClienteCodigo(Convert.ToInt32(this.dgvClientes.SelectedRows[0].Cells[0].Value.ToString()));
        this.Close();
      }
      if (this.modulo.Equals("factura_electronica"))
      {
        this.frmFacElectronic.buscaClienteCodigo(Convert.ToInt32(this.dgvClientes.SelectedRows[0].Cells[0].Value.ToString()));
        this.Close();
      }
      if (this.modulo.Equals("factura_exenta_electronica"))
      {
        this.frmFacExeElectronic.buscaClienteCodigo(Convert.ToInt32(this.dgvClientes.SelectedRows[0].Cells[0].Value.ToString()));
        this.Close();
      }
      if (this.modulo.Equals("nota_credito_electronica"))
      {
        this.frmNCElectronic.buscaClienteCodigo(Convert.ToInt32(this.dgvClientes.SelectedRows[0].Cells[0].Value.ToString()));
        this.Close();
      }
      if (this.modulo.Equals("nota_debito_electronica"))
      {
        this.frmNDElectronic.buscaClienteCodigo(Convert.ToInt32(this.dgvClientes.SelectedRows[0].Cells[0].Value.ToString()));
        this.Close();
      }
      if (this.modulo.Equals("guia_electronica"))
      {
        this.frmGuiaElectronic.buscaClienteCodigo(Convert.ToInt32(this.dgvClientes.SelectedRows[0].Cells[0].Value.ToString()));
        this.Close();
      }
      if (this.modulo.Equals("boleta_electronica"))
      {
        this.frmBolElectronic.buscaClienteCodigo(Convert.ToInt32(this.dgvClientes.SelectedRows[0].Cells[0].Value.ToString()));
        this.Close();
      }
      if (this.modulo.Equals("factura_exenta"))
      {
        this.frmFacExe.buscaClienteCodigo(Convert.ToInt32(this.dgvClientes.SelectedRows[0].Cells[0].Value.ToString()));
        this.Close();
      }
      if (this.modulo.Equals("informe_factura"))
      {
        this.frmIFV.buscaClienteCodigo(Convert.ToInt32(this.dgvClientes.SelectedRows[0].Cells[0].Value.ToString()));
        this.Close();
      }
      if (this.modulo.Equals("ticket"))
      {
        this.frmTic.buscaClienteCodigo(Convert.ToInt32(this.dgvClientes.SelectedRows[0].Cells[0].Value.ToString()));
        this.Close();
      }
      if (this.modulo.Equals("boleta"))
      {
        this.frmBol.buscaClienteCodigo(Convert.ToInt32(this.dgvClientes.SelectedRows[0].Cells[0].Value.ToString()));
        this.Close();
      }
      if (this.modulo.Equals("boleta_fiscal"))
      {
        this.frmBolFis.buscaClienteCodigo(Convert.ToInt32(this.dgvClientes.SelectedRows[0].Cells[0].Value.ToString()));
        this.Close();
      }
      if (this.modulo.Equals("guia"))
      {
        this.frmGui.buscaClienteCodigo(Convert.ToInt32(this.dgvClientes.SelectedRows[0].Cells[0].Value.ToString()));
        this.Close();
      }
      if (this.modulo.Equals("notaCredito"))
      {
        this.frmNC.buscaClienteCodigo(Convert.ToInt32(this.dgvClientes.SelectedRows[0].Cells[0].Value.ToString()));
        this.Close();
      }
      if (this.modulo.Equals("nota_venta"))
      {
        this.frmNotVen.buscaClienteCodigo(Convert.ToInt32(this.dgvClientes.SelectedRows[0].Cells[0].Value.ToString()));
        this.Close();
      }
      if (this.modulo.Equals("cotizacion"))
      {
        this.frmCoti.buscaClienteCodigo(Convert.ToInt32(this.dgvClientes.SelectedRows[0].Cells[0].Value.ToString()));
        this.Close();
      }
      if (this.modulo.Equals("factura_guias"))
      {
        this.frmFacGui.buscaClienteCodigo(Convert.ToInt32(this.dgvClientes.SelectedRows[0].Cells[0].Value.ToString()));
        this.Close();
      }
      if (this.modulo.Equals("ordenTrabajo"))
      {
        this.frmOt.buscaClienteCodigo(Convert.ToInt32(this.dgvClientes.SelectedRows[0].Cells[0].Value.ToString()));
        this.Close();
      }
      if (this.modulo.Equals("comanda"))
      {
        this.frmComa.buscaClienteCodigo(Convert.ToInt32(this.dgvClientes.SelectedRows[0].Cells[0].Value.ToString()));
        this.Close();
      }
      if (this.modulo.Equals("modulo_facturacion_Aptusoft"))
      {
        this.frmMFF.buscaClienteCodigo(Convert.ToInt32(this.dgvClientes.SelectedRows[0].Cells[0].Value.ToString()));
        this.Close();
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
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToResizeColumns = false;
            this.dgvClientes.AllowUserToResizeRows = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(12, 12);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(840, 237);
            this.dgvClientes.TabIndex = 0;
            this.dgvClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellDoubleClick);
            this.dgvClientes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvClientes_KeyDown);
            // 
            // frmClienteMismoRut
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(864, 263);
            this.Controls.Add(this.dgvClientes);
            this.MaximizeBox = false;
            this.Name = "frmClienteMismoRut";
            this.ShowIcon = false;
            this.Text = "Cliente Encontrado";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

    }
  }
}
