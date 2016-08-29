 
// Type: Aptusoft.frmImportarDocumento
 
 
// version 1.8.0

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Aptusoft
{
  public class frmImportarDocumento : Form
  {
    private IContainer components = (IContainer) null;
    private string _moduloBuscar = "";
    private frmFactura frmFac = (frmFactura) null;
    private Label lblDocumento;
    private TextBox txtNumero;
    private Button btnBuscar;

    public frmImportarDocumento()
    {
      this.InitializeComponent();
    }

    public frmImportarDocumento(ref frmFactura f, string moduloBusca)
    {
      this.InitializeComponent();
      this.frmFac = f;
      this._moduloBuscar = moduloBusca;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.lblDocumento = new Label();
      this.txtNumero = new TextBox();
      this.btnBuscar = new Button();
      this.SuspendLayout();
      this.lblDocumento.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.lblDocumento.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblDocumento.ForeColor = Color.White;
      this.lblDocumento.Location = new Point(12, 21);
      this.lblDocumento.Name = "lblDocumento";
      this.lblDocumento.Size = new Size(214, 32);
      this.lblDocumento.TabIndex = 0;
      this.lblDocumento.Text = "Guia Despacho N°:";
      this.txtNumero.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtNumero.Location = new Point(12, 48);
      this.txtNumero.Name = "txtNumero";
      this.txtNumero.Size = new Size(214, 31);
      this.txtNumero.TabIndex = 1;
      this.txtNumero.TextAlign = HorizontalAlignment.Center;
      this.txtNumero.KeyPress += new KeyPressEventHandler(this.txtNumero_KeyPress);
      this.btnBuscar.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnBuscar.Location = new Point(12, 85);
      this.btnBuscar.Name = "btnBuscar";
      this.btnBuscar.Size = new Size(214, 41);
      this.btnBuscar.TabIndex = 2;
      this.btnBuscar.Text = "BUSCAR";
      this.btnBuscar.UseVisualStyleBackColor = true;
      this.btnBuscar.Click += new EventHandler(this.btnBuscar_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
//      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
      this.ClientSize = new Size(245, 147);
      this.Controls.Add((Control) this.btnBuscar);
      this.Controls.Add((Control) this.txtNumero);
      this.Controls.Add((Control) this.lblDocumento);
//      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Name = "frmImportarDocumento";
      this.Text = "Importar Documento";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private void buscarDocumento()
    {
      if (!this._moduloBuscar.Equals("GUIAS"))
        return;
      this.buscaGuias();
    }

    private void buscaGuias()
    {
      Guia guia = new Guia();
      int numGuia = Convert.ToInt32(this.txtNumero.Text.Trim());
      try
      {
        Venta veOB = guia.buscaGuiaFolio(numGuia);
        if (veOB.IdFactura != 0)
        {
          if (!veOB.Facturada)
          {
            List<DatosVentaVO> listaDetalle = guia.buscaDetalleGuiaIDGuia(veOB.IdFactura);
            if (this.frmFac == null)
              return;
            this.frmFac.buscaGuiaFolio(veOB, listaDetalle);
            this.Close();
          }
          else
          {
            int num1 = (int) MessageBox.Show(string.Concat(new object[4]
            {
              (object) "Guia ya Documentada en: ",
              (object) veOB.DocumentoVenta,
              (object) " Folio N°: ",
              (object) veOB.FolioFactura
            }), "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          }
        }
        else
        {
          int num2 = (int) MessageBox.Show("No Existe la Guia Consultada!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al llamar Guia " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void btnBuscar_Click(object sender, EventArgs e)
    {
      if (this.txtNumero.Text.Trim().Length > 0)
      {
        this.buscarDocumento();
      }
      else
      {
        int num = (int) MessageBox.Show("Debe Ingresar un Folio a Buscar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.txtNumero.Focus();
      }
    }

    private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtNumero);
    }

    private void soloNumeros(KeyPressEventArgs e, TextBox caja)
    {
      if ((int) e.KeyChar == 46)
        e.KeyChar = ',';
      if (caja.Text.Trim().Length == 0 && (int) e.KeyChar == 44)
        e.KeyChar = '0';
      if ((int) e.KeyChar == 8)
      {
        e.Handled = false;
      }
      else
      {
        bool flag = false;
        int num = 0;
        for (int index = 0; index < caja.Text.Length; ++index)
        {
          if ((int) caja.Text[index] == 44)
            flag = true;
          if (flag && num++ >= 4)
          {
            e.Handled = true;
            return;
          }
        }
        if ((int) e.KeyChar >= 48 && (int) e.KeyChar <= 57)
          e.Handled = false;
        else if ((int) e.KeyChar == 44)
          e.Handled = flag;
        else
          e.Handled = true;
      }
    }
  }
}
